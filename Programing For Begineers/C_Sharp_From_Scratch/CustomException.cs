using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_From_Scratch
{
    public class MyCustomException
    {
        public double Myprogram(double x, double y)
        {
            if (x == 0)
            {
                throw new DivideByZeroException();
            }
            if (y == 0)
            {
                throw new CustomException("Dividend cannot be zero");
            }
            return x/y;
        }
    }
    public class CustomException : Exception
    {
        public CustomException(string msg)
            : base(msg)
        {

        }


       

    }
}
