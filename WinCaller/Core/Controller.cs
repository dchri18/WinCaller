using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using WinCaller.Exceptions;

namespace WinCaller.Core
{
    /// <summary>
    /// Core operational class which holds global data regarding current instance of the application.
    /// </summary>
    public static class Controller
    {
        public static Settings Settings { get; private set; }

        private static readonly string SettingsJsonPath = $"{Directory.GetCurrentDirectory()}/bin/settings.json";

        public static PhoneBook PhoneBook { get; private set; }

        private static readonly string PhoneBookJsonPath = $"{Directory.GetCurrentDirectory()}/bin/phonebook.json";

        /// <summary>
        /// Initialises the Controller.
        /// </summary>
        public static void Initialise()
        {
            try
            {
                Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}/bin");

                // Initialise a Settings Instance
                // If one exists on local disk it will be deserialised here
                // If not, the user will be given the oportunity to create one in SetupForm.
                if (DoesSettingsExist())
                    LoadSettings();

                // Initialise a PhoneBook Instance
                // If one exists on local disk it will be deserialised here
                // If not, a new one will be created without any entries and saved straight away.
                if (DoesPhoneBookExist())
                {
                    LoadPhoneBook();
                } 
                else
                {
                    CreateNewPhoneBook();
                }
            }
            catch (Exception e)
            {
                throw new CoreException("Exception relating to Core namespace has been thrown", e);
            }
        }

        /// <summary>
        /// Creates a new Settings object based on given paramteres and save to local disk.
        /// </summary>
        public static void CreateNewSettings(string accountSid, string authToken, List<string> numbers, string currentNumber)
        {
            Settings = new Settings(accountSid, authToken, numbers, currentNumber);
            SaveSettings();

        }

        /// <summary>
        /// Saves the current Settings property.
        /// </summary>
        public static void SaveSettings()
        {
            var json = JsonConvert.SerializeObject(Settings, Formatting.Indented);
            File.WriteAllText(SettingsJsonPath, json);
        }

        /// <summary>
        /// Checks whether the settings json actually exists on local disk.
        /// </summary>
        private static bool DoesSettingsExist()
        {
            if (File.Exists(SettingsJsonPath))
                return true;
            return false;
        }

        /// <summary>
        /// Loads settings json from disk.
        /// </summary>
        private static void LoadSettings()
        {
            var json = File.ReadAllText(SettingsJsonPath);
            Settings = JsonConvert.DeserializeObject<Settings>(json);
        }

        /// <summary>
        /// Create an empty phone book and save object to local disk.
        /// </summary>
        private static void CreateNewPhoneBook()
        {
            PhoneBook = new PhoneBook();
             SavePhoneBook();
        }

        /// <summary>
        /// Save phone book object to local disk.
        /// </summary>
        public static void SavePhoneBook()
        {
            var json = JsonConvert.SerializeObject(PhoneBook, Formatting.Indented);
            File.WriteAllText(PhoneBookJsonPath, json);
        }

        /// <summary>
        /// Checks to see if phone book exists on local disk.
        /// </summary>
        private static bool DoesPhoneBookExist()
        {
            if (File.Exists(PhoneBookJsonPath))
                return true;
            return false;
        }

        /// <summary>
        /// Loads the phone book from local disk.
        /// </summary>
        private static void LoadPhoneBook()
        {
            var json = File.ReadAllText(SettingsJsonPath);
            PhoneBook = JsonConvert.DeserializeObject<PhoneBook>(json);
        }
    }
}
