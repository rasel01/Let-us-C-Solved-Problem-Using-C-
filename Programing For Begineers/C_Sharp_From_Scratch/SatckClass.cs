using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_From_Scratch
{
    public class SatckClass
    {

        public void DeclareStack()
        {
            Stack<int> stack1 = new Stack<int>();
            stack1.Push(100);
            int check = stack1.Pop();
            Console.WriteLine("last stack value is :{0}", check);
        }

        public void AddRemoveValueQueue()
        {
            Stack<int> Stackobj = new Stack<int>();
            // add value to queue :
            Console.WriteLine("\n" + "add value to stack" + "\n");
            for (int i = 0; i < 5; i++)
            {
                Stackobj.Push(i);

                Console.WriteLine(i);
            }
            // display the adding values :
            Console.WriteLine("\n" + "display the adding values" + "\n");
            foreach (int q in Stackobj)
            {
                Console.WriteLine("{0}", q);
            }

            // check the  last dequeu value :
            var lastStack = Stackobj.Pop();
            Console.WriteLine("last Pop value :{0}", lastStack);
            lastStack = Stackobj.Pop();
            Console.WriteLine("2nd Pop value :{0}", lastStack);
            lastStack = Stackobj.Pop();
            Console.WriteLine("third Pop value :{0}", lastStack);
            lastStack = Stackobj.Pop();
            Console.WriteLine("forth Pop value :{0}", lastStack);
            lastStack = Stackobj.Pop();
            Console.WriteLine("fifth Pop value :{0}", lastStack);

        }
    }
}
