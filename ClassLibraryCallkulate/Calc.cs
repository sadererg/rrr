using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCallkulate.Calc
{
    public class ClassLibraryCallkulateCalc
    {       
        public double Calc(double Number1, double Number2, string Operation)
        {
            double Result = 0;
            switch (Operation)
            {
                case "Add":
                    Result = Number1 + Number2;
                    break;
                case "Sub":
                    Result = Number1 - Number2;
                    break;
                case "Mul":
                    Result = Number1 * Number2;
                    break;
                case "Div":
                    Result = Number1 / Number2;
                    break;
                default:
                    Result = 0;
                    break;
            }
            return Result;
        }
    }
}
