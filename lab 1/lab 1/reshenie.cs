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
            
        }
    }
}
