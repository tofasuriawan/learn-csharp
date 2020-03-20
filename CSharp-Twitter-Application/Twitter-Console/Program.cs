using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetManager;

namespace Twitter_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            TweetManagerFile tm = new TweetManagerFile();

            do
            {
                Console.WriteLine("-----Main Menu-----");
                Console.WriteLine();
                Console.WriteLine("1. View All Tweets");
                Console.WriteLine("2. Post New Tweet");
                Console.WriteLine("3. Search Tweets");
                Console.WriteLine("4. Exit");

                Console.WriteLine();
                Console.Write("Your choice : ");
                choice = Console.ReadLine();

                Console.WriteLine($"You choose #{choice}");
                Console.WriteLine();

                if (choice == "1")
                {
                    for (int i = 0; i < tm.Count(); i++)
                    {
                        Console.WriteLine($"Tweet #{i + 1}: {tm.Get()[i]}");
                    }
                }
                else if (choice == "2")
                {
                    Console.Write("Enter your tweet: ");
                    string tweet = Console.ReadLine();
                    string result = tm.Post(tweet);
                    Console.WriteLine(result);
                }
                else if (choice == "3")
                {
                    Console.Write("Enter search term: ");
                    string term = Console.ReadLine();
                    List<string> result = tm.Search(term);
                    Console.WriteLine($"Found {result.Count} tweet(s)");
                    foreach (string tweet in result)
                    {
                        Console.WriteLine($"{tweet}");
                    }
                }
                
                Console.WriteLine();
            }
            while (choice != "4");

        }
    }
}
