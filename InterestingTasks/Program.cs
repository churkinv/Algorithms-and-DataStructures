using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace InterestingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose number of task: \n1) String input, and show the most frequent characters");

            switch (Console.ReadLine())
            {
                case "1":
                    #region Task 1
                    // Реализовать метод, который принимает на вход строку 
                    // и возвращает коллекцию символов, которые встречаются чаще всего
                    // Пример: 
                    // - ааа ббб с
                    // - а, б
                    // - ааа бб с
                    // - а
                    // - а, б, с
                    // - а б с
                    // Как модифицировать алгоритм, чтобы количество итераций, было меньше
                    // чем символов в строке

                    Console.WriteLine("Please input text:");
                    string input = Console.ReadLine();

                    Stopwatch stopwatch = new Stopwatch();

                    stopwatch.Start();
                    ShowTheMostFrequentCharacters(input);
                    stopwatch.Stop();

                    Console.WriteLine("\nNot optimized: " + stopwatch.ElapsedMilliseconds);

                    stopwatch.Start();
                    ShowTheMostFrequentCharactersOptimized(input);
                    stopwatch.Stop();

                    Console.WriteLine("\nOptimized: " + stopwatch.ElapsedMilliseconds);
                    Console.ReadKey();
                    break;
                    #endregion
            }
        }

        /// <summary>
        /// Not perfect one
        /// </summary>
        /// <param name="input"></param>
        private static IEnumerable<char> ShowTheMostFrequentCharacters(string input)
        {
            char[] symbols = input.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < symbols.Length; i++)
            {
                if (dict.ContainsKey(symbols[i]))
                {
                    dict[symbols[i]]++;
                }
                else
                {
                    dict.Add(symbols[i], 1);
                }
            }

            var ordered = dict.OrderByDescending(x => x.Value);
            IEnumerable<char> selected = from t in ordered
                                         where t.Value == ordered.FirstOrDefault().Value
                                         orderby t.Value
                                         select t.Key;
            
            foreach (var item in selected)
            {
                Console.Write(item);
            }

            return selected;
        }

        /// <summary>
        /// not finished, to refactor
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static IEnumerable<char> ShowTheMostFrequentCharactersOptimized(string input)
        {
            SortedSet<char> sortedSet = new SortedSet<char>();
            char[] symbols = input.ToCharArray();

            for (int i = 0; i < symbols.Length; i++)
            {
                sortedSet.Add(symbols[i]);
            }

            foreach (var item in sortedSet)
            {
                Console.Write(item);
            }

            return sortedSet;
        }
    }
}
