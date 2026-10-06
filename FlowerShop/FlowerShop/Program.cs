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

            int[] orderQuantities = new int[5];

            while (true)
            {
                int flowerIndex = GetValidIntInput("Введите номер цветка (0 - конец заказа): ", 0, 5);

                if (flowerIndex == 0)
                {
                    break;
                }

                int arrayIndex = flowerIndex - 1;

                int quantity = GetValidIntInput("Введите количество: ", 1, int.MaxValue);

                orderQuantities[arrayIndex] += quantity;
            }
            ProcessOrder(orderQuantities);
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
        static void ProcessOrder(int[] orderQuantities)
        {
            bool canSell = true;

            for (int i = 0; i < orderQuantities.Length; i++)
            {
                if (orderQuantities[i] > stocks[i])
                {
                    canSell = false;
                    Console.WriteLine($"Не хватает цветка: {names[i]}");
                }
            }

            if (canSell)
            {
                int totalCost = 0;

                for (int i = 0; i < orderQuantities.Length; i++)
                {
                    stocks[i] -= orderQuantities[i];
                    totalCost += orderQuantities[i] * prices[i];
                }

                Console.WriteLine($"Стоимость заказа: {totalCost} руб.");
            }
            else
            {
                Console.WriteLine("Заказ не может быть выполнен (недостаточно товара).");
            }

            PrintStocks();
        }

        static void PrintStocks()
        {
            Console.Write("Остатки цветов: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]} {stocks[i]}");
                if (i < names.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
