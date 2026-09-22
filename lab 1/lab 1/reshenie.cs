using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class reshenie
    {
        public double InputHeight()
        {
            double height;
            while (true)
            {
                Console.Write("Введите рост (см): ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out height) && height > 0)
                {
                    return height;
                }
                Console.WriteLine("Ошибка! Введите положительное число.");
            }
        }

        public double InputWeight()
        {
            double weight;
            while (true)
            {
                Console.Write("Введите вес (кг): ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out weight) && weight > 0)
                {
                    return weight;
                }
                Console.WriteLine("Ошибка! Введите положительное число.");
            }
        }

        public double CalculateBMI(double height, double weight)
        {
            double heightInMeters = height / 100.0;
            return weight / (heightInMeters * heightInMeters);
        }
    }
}
