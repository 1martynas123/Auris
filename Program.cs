using System;

namespace ConsoleApp1
{
  
    class Program
    {
        public static int numberOfContact = 0;
        public static string[] Contact = new string[100];
        public static string[] Name = new string[100];
        public static string[] Surname = new string[100];
        public static string[] Phone = new string[100];
        public static int once = 0;


        static void Main()
        {
           
            once = once + 1;
            if (once < 2)
            {
                Console.WriteLine("Welcome, to PhoneBook program \n");
                Help();
            }
            string choice = Console.ReadLine();
            if (choice == "Add")
            {
                Add();
            }
            if (choice == "Find")
            {
                Find();
            }
            if (choice == "Remove")
            {
                Remove();
            }
            if (choice == "View")
            {
                View();
            }
            if (choice == "Help")
            {
                Help();
            }
            else {
                  Main();
            }
            Console.ReadLine();
        }


        //Create new Contact part
        static void Add()
        {    
            numberOfContact = numberOfContact + 1;
           
            Console.WriteLine("Iveskite Varda");
            Name[numberOfContact] = Console.ReadLine();
            Console.WriteLine("Iveskite Pavarde");
            Surname[numberOfContact] = Console.ReadLine();
            Console.WriteLine("Iveskite Telefono numeri");
            Phone[numberOfContact] = Console.ReadLine();
            Contact[numberOfContact] = "\n" + Name[numberOfContact] +" "
                + Surname[numberOfContact]+"\n" + Phone[numberOfContact];
            Console.WriteLine(Contact[numberOfContact]);
            Main();
        }
        //Find existing Contact part
        static void Find()
        {
            Console.WriteLine("Find by name or surname: ");
            string search = Console.ReadLine();
            int i = 0;
            do
            {
                i = i + 1;
                if ((search == Name[i]) || (search == Surname[i]))
                {
                    Console.WriteLine(Contact[i]);
                    i = numberOfContact;
                    Main();
                }
            } while (i != numberOfContact);
          
                Console.WriteLine("0 Matches Found by the name " + search + "\n");
                Help();
            





        }
        //Remove existing Contact part
        static void Remove()
        {
            Console.WriteLine("Delete Contact by name or surname: ");
            string search = Console.ReadLine();
            int i = 0;
            do
            {
                i = i + 1;
                if ((search == Name[i]) || (search == Surname[i]))
                {
                    Console.WriteLine(Contact[i]+ "Is deleted");
                    Contact[i] = null;
                    i = numberOfContact;
                    Main();
                }
            } while (i != numberOfContact);
          
                Console.WriteLine("0 Matches Found by the name " + search + "\n");
                Help();     
        }
        //View all Contacts part
        static void View()
        {
            int i = 0;
            do
            {
                i = i + 1;
                Console.WriteLine(Contact[i]);
            } while (i != numberOfContact);
            Main();
        }
        static void Help()
        {
            Console.WriteLine("To Add new contact, type (Add)");
            Console.WriteLine("To Find existing contact, type (Find)");
            Console.WriteLine("To Remove existing contact, type (Remove)");
            Console.WriteLine("To view all contacts, type (View)");
            Console.WriteLine("if you want to see help menu, type (Help) \n");
        }
    
    }
}
