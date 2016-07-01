using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_From_Scratch
{
    public class BooleanExpression
    {
        public void BoolExpressMethod()
        {
            bool equal = 3 + 2 == 5;
            Console.WriteLine("Equal Expression using bool => " + equal);

            bool greater = 6 > 5;
            Console.WriteLine("greater than  Expression using bool => " + greater);

            bool less = 6 < 5;
            Console.WriteLine("less than  Expression using bool => " + less);

            bool and = 6==5 && 7==7;
            Console.WriteLine("And   Expression using bool => " + and);

            bool or = 6 > 5 || 6 < 4;
            Console.WriteLine("OR  Expression {0} using bool => " , or);

            bool notEqual = 6 != 5;
            Console.WriteLine("NotEqual  Expression {0} using bool => ", greater);
            
            






        }
    }
}
