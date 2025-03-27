using System;
using System.IO;
namespace Task_1
{

    class Program
    {
        static void Main()
        {
            WriteFriendsToFile();
        }

        static void WriteFriendsToFile()
        {
            string[] friends = { "\nAlice", " \nBob", "\nCharlie", "\nDavid", "\nEve" };
            File.WriteAllLines("friends.txt", friends);
            Console.WriteLine("Friends' names written to file.");
        }
    }

}