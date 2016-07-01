using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_From_Scratch
{
    public class DelegatesCalsses
    {

        public delegate int DelegateMethod();

        public void RunDelegate(DelegateMethod testDelegateMethod)
        {
            int result = testDelegateMethod();
            if (result  > 0)
            {
                Console.WriteLine("Successfully delegate works !"); 
            }
            else
            {
                Console.WriteLine("failed delegate method "); 
            }

        }
    }
}
