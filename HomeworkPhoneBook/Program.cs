using System;

namespace HomeworkPhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cycle = true;
            ContactBook contactBook = new ContactBook();

            Console.WriteLine("select an action");
            Console.WriteLine("1-make contact");
            Console.WriteLine("2-add a contact");
            Console.WriteLine("3-remove a contact");
            Console.WriteLine("4-call out all contacts ");
            Console.WriteLine("0-exit");
            bool check = Int32.TryParse(Console.ReadLine(), out int selection);

            while (cycle)
            {
                if (check)
                {
                    switch (selection)
                    {
                        case 0:
                            cycle = false;
                            break;
                        case 1:
                            Console.WriteLine("enter a contact name");
                            string index = Console.ReadLine();
                            Console.WriteLine(contactBook[index]);
                            break;
                        case 2:
                            break;
                        case 3:
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