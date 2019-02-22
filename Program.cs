using System;

namespace ConsoleApp1
{
  
    class Program
    {
        public static int numberOfContact = 0;
        public static int i = 0;
        public static string[] Contact = new string[100];
        public static string[] Name = new string[100];
        public static string[] Surname = new string[100];
        public static string[] Phone = new string[100];
        public static bool once = false;


        static void Main()
        {
           
           
            if (once == false)
            {
                Console.WriteLine("Welcome, to PhoneBook program \n");
                Help();
                once = true;
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
            if (choice == "Exit")
            {
                Exit();
            }
            if (choice == "Help")
            {
                Help();
                Main();
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
           
            Console.WriteLine("Name: ");
            Name[numberOfContact] = Console.ReadLine();
            Console.WriteLine("Surname: ");
            Surname[numberOfContact] = Console.ReadLine();
            Console.WriteLine("Phone number: ");
            Phone[numberOfContact] = Console.ReadLine();
            Contact[numberOfContact] = "\n" + Name[numberOfContact] +" "
                + Surname[numberOfContact]+"\n" + Phone[numberOfContact];
            Console.WriteLine("\n"+Contact[numberOfContact]+"\n");
            Main();
        }
        //Find existing Contact part
        static void Find()
        {
            if (numberOfContact > 0)
            {
                Console.WriteLine("\n Find by name or surname: ");
                string search = Console.ReadLine();
                i = 0;
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
                Console.WriteLine("\n 0 Matches Found by the name " + search + "\n");
            } else
            {
                Console.WriteLine("\n You have 0 contacts \n");
            }
           
        }
        //Remove existing Contact part
        static void Remove()
        {
            Console.WriteLine("\n Delete Contact by name or surname: ");
            string search = Console.ReadLine();
            i = 0;
            do
            {
                i = i + 1;
                if ((search == Name[i]) || (search == Surname[i]))
                {
                    Console.WriteLine(Contact[i]+ " Is deleted");
                    Contact[i] = null;
                    Name[i] = null;
                    Surname[i] = null;
                    Phone[i] = null;
                    numberOfContact = numberOfContact - 1;
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
            if (numberOfContact > 0)
            {
                int i = 0;
                do
                {
                    i = i + 1;
                    Console.WriteLine(Contact[i]);
                } while (i != numberOfContact);
                Main();
            }
            else
            {
                Console.WriteLine("\n You have 0 contacts \n");
            }
        }
        static void Exit()
        {
           Environment.Exit(0);
        }
        static void Help()
        {
            Console.WriteLine("To Add new contact, type (Add)");
            Console.WriteLine("To Find existing contact, type (Find)");
            Console.WriteLine("To Remove existing contact, type (Remove)");
            Console.WriteLine("To view all contacts, type (View)");
            Console.WriteLine("To close the program, type (Exit)");
            Console.WriteLine("if you want to see help menu, type (Help) \n");
            
        }
    
    }
}
