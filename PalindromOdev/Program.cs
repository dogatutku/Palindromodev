
using System;
using System.Numerics;

namespace PalindromOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string kelimenindüzhali;
            string kelimenintershali;
            Console.WriteLine("kelime giriniz");
            kelimenindüzhali = Console.ReadLine();
            while (kelimenindüzhali != "q")
            {
                if (kelimenindüzhali.Length >= 3)
                {
                    kelimenintershali = "";
                    for (int i = kelimenindüzhali.Length - 1; i >= 0; i--)
                    {
                        kelimenintershali += kelimenindüzhali[i];
                    }
                    if (kelimenindüzhali == kelimenintershali)
                    {
                        Console.WriteLine("Kelime Palindromdur");
                    }
                    else
                    {
                        Console.WriteLine("Kelime Palindrom değildir");
                    }
                }
                else
                {
                    Console.WriteLine("En az 3 karakterli bir kelime giriniz!!");
                }
                kelimenindüzhali = Console.ReadLine();
            }
            


        }
    }
}
