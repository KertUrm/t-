using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace töö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "1":
                    LastOrDefault();
                    break;
                case "2":
                    Where();
                    break;
                case "3":
                    CreateFile();
                    break;
                case "4":
                    Triangle();
                    break;
                default:
                    break;
            }
        }
        public static void LastOrDefault()
        {
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            List<int> empty = new List<int>();
            Console.WriteLine(empty.LastOrDefault());
            Console.WriteLine(numbers.LastOrDefault());
        }
        public static void Where()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            foreach (int i in numbers.Where(x => x%2 == 1))
            {
                Console.WriteLine(i);
            }
        }
        public static void CreateFile()
        {
            Console.WriteLine("koht");
            string koht = Console.ReadLine();
            if (koht != "")
            {
                try
                {
                    File.WriteAllText(koht + "/text.txt", Console.ReadLine());
                    Console.WriteLine("tehtud");
                }
                catch (Exception)
                {
                    Console.WriteLine("Kohta ei ole olemas");
                }
                
            }
            else
            {
                Console.WriteLine("kohta ei ole  valitud");
                try
                {
                    File.WriteAllText(koht + "/text.txt", Console.ReadLine());
                    Console.WriteLine("tehtud");
                }
                catch (Exception)
                {
                    Console.WriteLine("Kohta ei saa salvestade");
                }
            }
        }
        public static void Triangle()
        {
            int size = 4;
            int n = 1;
            int n3 = size;
            for (int i = 0; i < size; i++)
            {
                Console.Write(new String(' ', n3));
                n3--;
                for (int j = n; j <= n + i; j++)
                {
                    Console.Write(j + " ");
                }
                n += i+1;
                Console.WriteLine();
            }
        }
    }
}
