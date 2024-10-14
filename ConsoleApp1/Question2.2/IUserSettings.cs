using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Question2
{
    public interface IUserSettings
    {
        /// <summary>
        /// Write user Settings
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="settings"></param>
        void WriteSettings(string filePath, Dictionary<string, string> settings);

        /// <summary>
        /// Read user Settings
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        Dictionary<string, string> ReadSettings(string filePath);
    }
}
