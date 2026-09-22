using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Program
    {
        public void ShowResult(double height, double weight, double bmi, string category, string recommendation)
        {
            Console.WriteLine($"Рост: {height} см");
            Console.WriteLine($"Вес: {weight} кг");
            Console.WriteLine($"ИМТ: {bmi:F1}");
            Console.WriteLine($"Категория: {category}");
            Console.WriteLine($"Рекомендация: {recommendation}");

        }
    }
}
