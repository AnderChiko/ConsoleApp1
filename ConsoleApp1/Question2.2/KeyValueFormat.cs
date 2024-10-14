using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Question2
{

    // This is the most space-efficient format where each line represents a key-value pair in the form key=value
    public class KeyValueFormat : IUserSettings
    {
        /// <inheritdoc/>
        public void WriteSettings(string filePath, Dictionary<string, string> settings)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var kv in settings)
                {
                    writer.WriteLine($"{kv.Key}={kv.Value}");
                }
            }
        }

        /// <inheritdoc/>
        public Dictionary<string, string> ReadSettings(string filePath)
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('=');
                if (parts.Length == 2)
                {
                    settings[parts[0]] = parts[1];
                }
            }
            return settings;
        }
    }
}
