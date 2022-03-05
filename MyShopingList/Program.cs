using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShopingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\samples\shopinglist";
            string fileName = @"\\myShopingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShopingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add something to shopinglist? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter what you like:");
                    string userWish = Console.ReadLine();
                    myShopingList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }

            }
            Console.Clear();

            foreach (string thing in myShopingList)
            {
                Console.WriteLine($"Your things: {thing}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", myShopingList);
        }
    }
}
