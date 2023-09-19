using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.BelovaEA.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("(x + y + z) * 5");

            Console.WriteLine("Введите x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите z:");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("Ответ: " + ds.Calc(x,y,z));
            Console.ReadKey();
        }
    }
}
