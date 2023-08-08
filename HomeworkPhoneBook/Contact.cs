using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPhoneBook
{
    public class Contact
    {
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public Contact(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public void Call()
        {
            Console.WriteLine($"you call {this.name}");
        }
    }
}
