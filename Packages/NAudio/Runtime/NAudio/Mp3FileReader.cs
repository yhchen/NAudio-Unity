using System.IO;

// ReSharper disable once CheckNamespace
namespace NAudio.Wave
{

    /// <summary>
    /// Class for reading from MP3 files
    /// </summary>
    public class Mp3FileReader : Mp3FileReaderBase
    {
        /// <summary>Supports opening a MP3 file</summary>
        public Mp3FileReader(string mp3FileName, FrameDecompressorBuilder decompressorBuilder)
            : base(File.OpenRead(mp3FileName), decompressorBuilder, true)
        {
        }

        /// <summary>
        /// Opens MP3 from a stream rather than a file
        /// Will not dispose of this stream itself
        /// </summary>
        /// <param name="inputStream">The incoming stream containing MP3 data</param>
        /// <param name="decompressorBuilder"></param>
        public Mp3FileReader(Stream inputStream, FrameDecompressorBuilder decompressorBuilder)
            : base(inputStream, decompressorBuilder, false)
        {

        }
    }
}
