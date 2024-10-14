namespace ConsoleApp1.Question2
{
    public class UserSettingManager : IUserSettingManager
    {
        public bool IsFeatureEnabled(string settings, int setting)
        {
            if (setting < 1 || setting > settings.Length)
            {
                throw new ArgumentOutOfRangeException($"Setting must be between 1 and { settings.Length }.");
            }

            // Convert 1-based index to 0-based index
            int index = setting - 1;

            // Check if the character at the position is '1'
            return settings[index] == '1';
        }
    }
}
