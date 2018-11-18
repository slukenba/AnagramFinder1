using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace AnagramFinder1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the Anagram Finder");
                Console.WriteLine("-----------------------------");
                Stopwatch aTimer = new Stopwatch();
                aTimer.Start();

                string path = Path.Combine(Environment.CurrentDirectory, args[0]);

                var logFile = File.ReadAllLines(path);
                aTimer.Stop();

                Console.WriteLine("Dictionary loaded in " + aTimer.ElapsedMilliseconds + " ms");

                Console.Write("AnagramFinder>");
                string userInput = Console.ReadLine();

                while (userInput != "exit")
                {
                    var orderUserInput = String.Concat(userInput.OrderBy(c => c));
                    List<string> resultList = new List<string>();

                    Stopwatch aResultTimer = new Stopwatch();
                    aResultTimer.Start();

                    foreach (var i in logFile)
                    {
                        string elementToAdd = String.Concat(i.OrderBy(c => c));
                        if (elementToAdd == orderUserInput)
                            resultList.Add(i);
                    }
                    aResultTimer.Stop();

                    if (resultList != null && resultList.Count > 0)
                    {
                        Console.WriteLine(resultList.Count + " Anagrams found for " + userInput + " in " + aResultTimer.ElapsedMilliseconds + "ms");
                        Console.WriteLine(string.Join(",", resultList));
                    }
                    else
                        Console.WriteLine("No anagrams found for " + userInput + " " + aResultTimer.ElapsedMilliseconds + "ms");

                    Console.Write("AnagramFinder>");
                    userInput = Console.ReadLine();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("ERROR: Could not find the dictionary file!");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR: Unexpected Error!");
                Console.ReadLine();
            }
        }
    }
}