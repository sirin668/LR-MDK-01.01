using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    internal class Program
    {
        static string[] names = { "роза", "тюльпан", "хризантема", "орхидея", "гипсофила" };
        static int[] prices = { 180, 120, 350, 1200, 90 };
        static int[] stocks = { 24, 30, 14, 6, 40 };
        static void Main(string[] args)
        {
            PrintAssortment();
        }
        static void PrintAssortment()
        {
            Console.WriteLine("Ассортимент:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]} — {prices[i]} руб., {stocks[i]} шт.");
            }
        }
        static int GetValidIntInput(string message, int min, int max)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                int number;

                if (int.TryParse(input, out number))
                {
                    if (number >= min && number <= max)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка: число должно быть от {min} до {max}.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: нужно ввести целое число.");
                }
            }
        }
    }
}
