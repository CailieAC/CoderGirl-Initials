using System;

namespace Initials
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            string initials = Initials(name);
            Console.WriteLine(initials);
            Console.ReadLine();
        }

        // TODO: Create a method that takes in a full name and return the initials in all capital letters.
        public static string Initials(string name)
        {
            string initials = "";
            string[] arrayOfName = name.Split(' ');
            char[] arrayOfInitials = new char[arrayOfName.Length];
            for (int i = 0; i < arrayOfName.Length; i++)
            {
                arrayOfName[i] = arrayOfName[i].ToUpper().Trim();
                arrayOfInitials[i] = arrayOfName[i][0];
            }

            initials = String.Join("", arrayOfInitials);
            return initials;
        }
    }
}
