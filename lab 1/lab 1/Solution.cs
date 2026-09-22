using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Solution
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

        public string GetCategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Недостаточный вес";
            }
            else if (bmi < 25)
            {
                return "Норма";
            }
            else if (bmi < 30)
            {
                return "Избыточный вес";
            }
            else
            {
                return "Ожирение";
            }

        }
        public string GetRecommendation(string category)
        {
            if (category == "Недостаточный вес")
            {
                return "Увеличьте калорийность рациона.";
            }
            else if (category == "Норма")
            {
                return "Поддерживайте текущий образ жизни.";
            }
            else if (category == "Избыточный вес")
            {
                return "Увеличьте физическую активность.";
            }
            else
            {
                return "Обратитесь к врачу.";
            }

        }
    }
}
