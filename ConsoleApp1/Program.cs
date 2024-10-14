// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Question2;

Console.WriteLine("Hello, World!");


// Test case 1: settings = 00000000, setting = 7 (feature 7 is disabled)
Console.WriteLine(new UserSettingManager().IsFeatureEnabled("00000000", 7));  // Output: False

// Test case 2: settings = 00000010, setting = 7 (feature 7 is enabled)
Console.WriteLine(new UserSettingManager().IsFeatureEnabled("00000010", 7));  // Output: True

// Test case 3: settings = 11111111, setting = 4 (feature 4 is enabled)
Console.WriteLine(new UserSettingManager().IsFeatureEnabled("11111111", 4));  // Output: True