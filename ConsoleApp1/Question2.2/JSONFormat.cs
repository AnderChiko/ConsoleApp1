using Newtonsoft.Json;

namespace ConsoleApp1.Question2
{

    // Using JSON offers more flexibility, especially if settings have more complex structures, while remaining relatively compact.
    public class JSONFormat : IUserSettings
    {
        /// <inheritdoc/>
        public void WriteSettings(string filePath, Dictionary<string, string> settings)
        {
            var json = JsonConvert.SerializeObject(settings, Formatting.None);  // Formatting.None for compact format
            File.WriteAllText(filePath, json);
        }

        /// <inheritdoc/>
        public Dictionary<string, string> ReadSettings(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
    }
}
