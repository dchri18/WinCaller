using System;
using System.Collections.Generic;
using System.Text;

namespace WinCaller.Core
{
    public class Settings
    {
        public string AccountSid { get; private set; }
        public string AuthToken { get; private set; }
        public List<string> Numbers { get; private set; }
        public string CurrentNumber { get; private set; }

        public Settings(string accountSid, string authToken, List<string> numbers, string currentNumber)
        {
            AccountSid = accountSid;
            AuthToken = authToken;
            Numbers = numbers;
            CurrentNumber = currentNumber;
        }

        public void AddNumber(string number)
        {
            Numbers.Add(number);
        }

        public bool RemoveNumber(string number)
        {
            return Numbers.Remove(number);
        }

        public void ClearNumbers()
        {
            Numbers.Clear();
        }

        public void SetCurrentNumber(string number)
        {
            CurrentNumber = number;
        }
    }
}
