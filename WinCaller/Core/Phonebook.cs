using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCaller.Core
{
    public class PhoneBook
    {
        /// <summary>
        /// Tuple(FirstName, LastName, PhoneNumber)
        /// </summary>
        public List<Tuple<string, string, string>> Entries { get; private set; }

        public PhoneBook()
        {
            Entries = new List<Tuple<string, string, string>>();
        }

        public PhoneBook(List<Tuple<string, string, string>> entries)
        {
            Entries = entries;
        }

        /// <summary>
        /// Adds a new Phone Book Entry.
        /// </summary>
        public void AddEntry(string firstName, string lastName, string number)
        {
            Entries.Add(new Tuple<string, string, string>(firstName, lastName, number));
        }

        /// <summary>
        /// Removes an entry based on a given phone number.
        /// </summary>
        public void RemoveEntryOnNumber(string number)
        {
            Entries.RemoveAll(item => item.Item3 == number);
        }

        /// <summary>
        /// Clear all entries.
        /// </summary>
        public void ClearAllEntries()
        {
            Entries.Clear();
        }
    }
}
