using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuild
{
    internal class Program
    {
        static string[] names = { "процессор", "оперативная память", "видеокарта", "накопитель", "блок питания" };
        static int[] prices = { 18500, 4200, 22000, 6500, 4800 };
        static int[] stock = { 12, 24, 8, 15, 20 };

        static void Main(string[] args)
        {
            PrintStock();
        }

        static void PrintStock()
        {
            Console.WriteLine("Комплектующие:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]} — {prices[i]} руб., {stock[i]} шт.");
            }
        }

        static int GetValidComponentIndex()
        {
            while (true)
            {
                Console.Write("Введите номер комплектующего (0 – конец заказа): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number >= 0 && number <= 5)
                    {
                        return number; 
                    }
                }
                Console.WriteLine("Ошибка: введите число от 0 до 5.");
            }
        }
    }
}