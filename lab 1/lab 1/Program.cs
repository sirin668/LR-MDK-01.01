using lab_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main()
        {
            Solution solution = new Solution();
            Output output = new Output();

            double height = solution.InputHeight();
            double weight = solution.InputWeight();
            double bmi = solution.CalculateBMI(height, weight);
            string category = solution.GetCategory(bmi);
            string recommendation = solution.GetRecommendation(category);

            output.ShowResult(height, weight, bmi, category, recommendation);

            Console.ReadKey();
        }
    }
    internal class Output
    {
        public void ShowResult(double height, double weight, double bmi,
                               string category, string recommendation)
        {
            Console.WriteLine($"Рост: {height} см");
            Console.WriteLine($"Вес: {weight} кг");
            Console.WriteLine($"ИМТ: {bmi:F1}");
            Console.WriteLine($"Категория: {category}");
            Console.WriteLine($"Рекомендация: {recommendation}");
        }
    }
}
