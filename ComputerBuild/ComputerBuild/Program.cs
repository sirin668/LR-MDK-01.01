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

            int[] orderQuantities = new int[5];
            bool isOrdering = true;

            while (isOrdering)
            {
                int componentIndex = GetValidComponentIndex();
                if (componentIndex == 0)
                {
                    isOrdering = false;
                }
                else
                {
                    int arrayIndex = componentIndex - 1;
                    int quantity = GetValidQuantity();
                    orderQuantities[arrayIndex] += quantity;
                }
            }
            ProcessOrder(orderQuantities);

            Console.ReadKey();
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
        static int GetValidQuantity()
        {
            while (true)
            {
                Console.Write("Введите количество: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number >= 0)
                    {
                        return number;
                    }
                }

                Console.WriteLine("Ошибка: количество не может быть отрицательным или не числом.");
            }
        }

        static void ProcessOrder(int[] order)
        {
            bool canBuild = true;
            string missingItem = "";

            for (int i = 0; i < stock.Length; i++)
            {
                if (order[i] > stock[i])
                {
                    canBuild = false;
                    missingItem = names[i];
                    break;
                }
            }

            if (canBuild)
            {
                double totalCost = 0;

                for (int i = 0; i < stock.Length; i++)
                {
                    stock[i] -= order[i];
                    totalCost += order[i] * prices[i];
                }

                Console.WriteLine($"Стоимость заказа: {totalCost} руб.");
            }
            else
            {
                Console.WriteLine($"Заказ не может быть выполнен. Не хватает: {missingItem}");
            }

            Console.Write("Остатки комплектующих: ");
            for (int i = 0; i < stock.Length; i++)
            {
                Console.Write($"{names[i]} {stock[i]}");
                if (i < stock.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}