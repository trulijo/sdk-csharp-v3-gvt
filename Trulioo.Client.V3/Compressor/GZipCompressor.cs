using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace Trulioo.Client.V3.Compressor
{
    /// <summary>
    /// GZip Compressor.
    /// </summary>
    internal class GZipCompressor
    {
        #region Public Methods

        /// <summary>
        /// Compress the stream.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static async Task Compress(Stream source, Stream destination)
        {
            using (var compressed = createCompressionStream(destination))
            {
                await pump(source, compressed).ContinueWith(task => compressed.Dispose()).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Decompress the stream.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static async Task Decompress(Stream source, Stream destination)
        {
            using (var decompressed = createDecompressionStream(source))
            {
                await pump(decompressed, destination).ContinueWith(task => decompressed.Dispose()).ConfigureAwait(false);
            }
                
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Create compression stream.
        /// </summary>
        /// <param name="output"></param>
        /// <returns>A compression stream</returns>
        private static Stream createCompressionStream(Stream output)
        {
            return new GZipStream(output, CompressionMode.Compress, true);
        }

        /// <summary>
        /// Create decompression stream.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>A decompression stream</returns>
        private static Stream createDecompressionStream(Stream input)
        {
            return new GZipStream(input, CompressionMode.Decompress, true);
        }

        /// <summary>
        /// Pump the stream.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        private static async Task pump(Stream input, Stream output)
        {
            await input.CopyToAsync(output).ConfigureAwait(false);
        }

        #endregion
    }
}
