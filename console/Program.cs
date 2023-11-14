using System;
using ClassLibraryCallkulate;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCallkulate.Calc;

namespace console.main
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");            
            Console.WriteLine();
            Console.WriteLine("Введите число 1");          
            var ch1 = Console.ReadLine();             
            Console.WriteLine("Введите число 2");
            var ch2 = Console.ReadLine();
            try
            {
                double c1 = Convert.ToInt32(ch1);
                double c2 = Convert.ToInt32(ch2);
                Console.WriteLine("Введите операцию (Add,Sub,Mul,Div)");
                string operat = Console.ReadLine();

                ClassLibraryCallkulateCalc calc = new ClassLibraryCallkulateCalc();
                double result = calc.Calc(c1, c2, operat);
                Console.WriteLine("Результат = " + result);
                Console.ReadKey();
            }
            catch
            {
                throw new NotImplementedException("Введены не числа");
            }          
            Console.ReadKey();
        }
    }
}
