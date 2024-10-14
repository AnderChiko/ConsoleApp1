using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Question2
{
    public interface IUserSettingManager
    {
        bool IsFeatureEnabled(string settings, int setting);
    }
}
