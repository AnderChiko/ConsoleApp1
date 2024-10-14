using Newtonsoft.Json;
using System.IO.Compression;

namespace ConsoleApp1.Question2
{

    // To minimize space further, we can apply compression to the JSON output using GZipStream or DeflateStream.
    public class CompressedJSON : IUserSettings
    {
        /// <inheritdoc/>
        public void WriteSettings(string filePath, Dictionary<string, string> settings)
        {
            var json = JsonConvert.SerializeObject(settings, Formatting.None);
            byte[] jsonData = System.Text.Encoding.UTF8.GetBytes(json);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            using (GZipStream gzip = new GZipStream(fs, CompressionMode.Compress))
            {
                gzip.Write(jsonData, 0, jsonData.Length);
            }
        }

        /// <inheritdoc/>
        public Dictionary<string, string> ReadSettings(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (GZipStream gzip = new GZipStream(fs, CompressionMode.Decompress))
            using (StreamReader reader = new StreamReader(gzip))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }
        }
    }
}
