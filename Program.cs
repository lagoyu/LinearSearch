using System;

namespace SearchArray
{
    class SearchArray
    {
        const int size = 5;
        static void Main(string[] args)
        {
            string[] myNames = new string[size];
            // 1. Read names from the user into an array called myNames
            CollectNames(myNames);
            // 2. Search the array to see where input name is present
            //    or not.
            string name = InputLine("Find name: ");
            while (name != "")
            {
                SearchForNames(name, myNames);
                name = InputLine("Find name (blank to end): ");
            }
            // 3. Prompt & wait before stopping program
            Pause();
        }

        static void CollectNames(string[] names)
        {
            // 1. Read names from the user into the array passed in
            //    note that arrays are passed by reference
            Console.WriteLine($"Enter {size} names, one per line.");
            for (int index = 0; index < size; index++)
            {
                // Non programmers don't like counting from 0!
                names[index] = InputLine($"{index+1}: ");
            }
            Console.WriteLine("All names have been stored.\n");
        }

        static int SearchForNames(string nameToFind, string[] names)
        {
            // 2. Search for the string within the array
            // YOU DO:
            int foundCount = 0;
            for (int index = 0; index < size; index++)
            {
                if (names[index] == nameToFind)     
                {
                    Console.WriteLine($"Found at {index+1}");
                    foundCount++;
                }
            }
            Console.WriteLine($"Found {foundCount} times.\n");
            return foundCount;
        }

        static string InputLine(string prompt)
        {
            Console.Write(prompt);
            string name = Console.ReadLine();
            return name;
        }

        static void Pause()
        {
            InputLine("\nEnter to Continue");
        }
    }
}
