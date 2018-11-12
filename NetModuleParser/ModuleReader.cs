using System;
using System.IO;
using System.Text;
using NetModuleParser.ParserInterfaces;
using NetModuleParser.Parsers;
using NetModuleParser.StructureElements;

namespace NetModuleParser
{
    public class ModuleReader : IDisposable
    {
        private readonly Stream _stream;
        public ModuleReader(Stream stream)
        {
            if (!stream.CanRead && !stream.CanSeek)
            {
                throw new ArgumentException("Seek or reed operations can not be performed with stream");
            }

            _stream = stream;
        }

        public ModuleReader(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            _stream = new FileStream(path, FileMode.Open);
        }

        private IByteParser<MsDosHeader> _msDosHeaderParser = new MsDosHeaderParser();

        public IByteParser<MsDosHeader> MsDosHeaderParser
        {
            get => _msDosHeaderParser;
            set => _msDosHeaderParser = value ?? throw new ArgumentNullException("1");
        }

        private IByteParser<MsDosStub> _msDosStubParser = new MsDosStubParser();

        public IByteParser<MsDosStub> MsDosStubParser
        {
            get => _msDosStubParser;
            set => _msDosStubParser = value ?? throw new ArgumentNullException("2");
        }

        private IByteParser<PeSignature> _peSignatureParser = new PeSignatureParser();

        public IByteParser<PeSignature> PeSignatureParser
        {
            get => _peSignatureParser;
            set => _peSignatureParser = value ?? throw new ArgumentNullException("3");
        }

        private IByteParser<CoffHeader> _coffHeaderParser = new CoffHeaderParser();

        public IByteParser<CoffHeader> CoffHeaderParser
        {
            get => _coffHeaderParser;
            set => _coffHeaderParser = value ?? throw new ArgumentNullException("4");
        }

        private IByteParser<PeHeader> _peHeaderParser = new PeHeaderParser();

        public IByteParser<PeHeader> PeHeaderParser
        {
            get => _peHeaderParser;
            set => _peHeaderParser = value ?? throw new ArgumentNullException("5");
        }
        //Text dla iskluchenii reshil ya ne pisat'

        public NetModule ReadNetModule()
        {
            return new NetModule
            (
                MsDosHeaderParser.Parse(new BinaryReader(_stream, Encoding.ASCII, true)),
                MsDosStubParser.Parse(new BinaryReader(_stream, Encoding.ASCII, true)),
                PeSignatureParser.Parse(new BinaryReader(_stream, Encoding.ASCII, true)),
                CoffHeaderParser.Parse(new BinaryReader(_stream, Encoding.ASCII, true)),
                PeHeaderParser.Parse(new BinaryReader(_stream, Encoding.ASCII, true))
            );
        }

        public void Dispose()
        {
            _stream?.Dispose();
        }
    }
}
