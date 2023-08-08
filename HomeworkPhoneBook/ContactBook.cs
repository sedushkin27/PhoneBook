using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeworkPhoneBook
{
    public class ContactBook
    {
        private Contact[] contacts = new Contact[30];

        public Contact this[string index]
        {
            get
            {
                for (int i = 0; i < contacts.Length; i++)
                {
                    if (contacts[i] != null && contacts[i].name == index)
                    {
                        return contacts[i];
                    }
                }
                return null;
            }
        }

        public void AddContact(string name, string phoneNumber)
        {
            for (int i = 0;i < contacts.Length;i++)
            {
                if (contacts[i] == null)
                {
                    contacts[i] = new Contact(name, phoneNumber);
                    break;
                }
            }
        }

        public void RemoveContact(string name)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i].name == name)
                {
                    contacts[i] = null;
                    break;
                }
            }
        }

        public void GetAllContacts()
        {
            for (int i = 0; i <contacts.Length; i++)
            {
                if (contacts[i] == null)
                {
                    Console.WriteLine("...");
                }
                else
                {
                    Console.WriteLine($"name: {contacts[i].name} phone number: {contacts[i].phoneNumber}");
                }
            }
        }

        //public string GetHystoryofCalls(Contact contact)
        //{ 
        //}
    }
}
