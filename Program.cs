using System;

namespace ConsoleApp1
{
  
    class Program
    {
        public static int plusOne = 0;
        public static string[] Name = new string[100];


        static void Main()
        {
            Console.WriteLine("Welcome, to PhoneBook program");
            Help();
            string choice = Console.ReadLine();
            if (choice == "Add")
            {
                Add();
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
            Console.ReadLine();
        }

       

        static void Add()
        {    //Create new Contact part
              plusOne = plusOne + 1;
           
            Console.WriteLine("Iveskite Varda");
            Name[plusOne] = Console.ReadLine();
            Main();


            Console.WriteLine("You chose to add new Contact");
        }
        static void Remove()
        {
            Console.WriteLine("You chose to Remove existing Contact");
            //Remove existing Contact part
        }
        static void View()
        {
            Console.WriteLine("You chose to View all Contacts");
            Console.WriteLine("You have "+ plusOne + "contacts");
            Console.WriteLine("You chose to View all Contacts");
            int i = 0;

            do
            {
                i = i + 1;
                Console.WriteLine(Name[i]);
            } while (i != plusOne);
            Main();




            //View all Contacts part
        }
        static void Help()
        {
            Console.WriteLine("To Add new contact, type (Add)");
            Console.WriteLine("To Remove existing contact, type (Remove)");
            Console.WriteLine("To view all contacts, type (View)");
            Console.WriteLine("if you want to see help menu, type (Help)");
        }
    
    }
}
