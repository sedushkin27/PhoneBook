using System;
using System.Net.Http.Headers;

namespace HomeworkPhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cycle = true;
            ContactBook contactBook = new ContactBook();

            while (cycle)
            {
            Console.WriteLine("select an action");
            Console.WriteLine("1-make contact");
            Console.WriteLine("2-add a contact");
            Console.WriteLine("3-remove a contact");
            Console.WriteLine("4-call out all contacts ");
            Console.WriteLine("0-exit");

            bool check = Int32.TryParse(Console.ReadLine(), out int selection);
            if (check)
            {
                switch (selection)
                {
                    case 0:
                        cycle = false;
                        break;
                    case 1:
                        {
                            Console.WriteLine("enter a contact name");
                            string index = Console.ReadLine();

                            Console.WriteLine($"name: {contactBook[index].name} phone number: {contactBook[index].phoneNumber}");
                            Console.WriteLine("select an action");
                            Console.WriteLine($"1-call {contactBook[index].name}");
                            Console.WriteLine("2-change contact name");
                            Console.WriteLine("3-change a contact's phone number");
                            Console.WriteLine("4-go back");
                            Console.WriteLine("0-exit");

                            selection = Convert.ToInt32(Console.ReadLine());

                            switch (selection)
                            {
                                case 1:
                                    contactBook[index].Call();
                                    break;

                                case 2:
                                    Console.WriteLine("enter a new contact name");
                                    contactBook[index].name = Console.ReadLine();
                                    break;

                                case 3:
                                    Console.WriteLine("enter the new phone number of the contact");
                                    contactBook[index].phoneNumber = Console.ReadLine();
                                    break;

                                case 4:
                                    break;

                                case 0:
                                    cycle = false;
                                    break;
                                default:
                                    cycle = false;
                                    break;

                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("enter a contact name");
                            string name = Console.ReadLine();

                            Console.WriteLine("enter the phone number of the contact");
                            string phoneNumber = Console.ReadLine();

                            contactBook.AddContact(name, phoneNumber);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("enter the name of the contact you want to delete");
                            string name = Console.ReadLine();

                            contactBook.RemoveContact(name);
                            break;
                        }
                    case 4:
                        contactBook.GetAllContacts();
                        break;
                    default:
                        cycle = false;
                        break;
                }
            }
            else
            {
                Console.WriteLine("There is no such option.");
            }
            }
        }
    }
}