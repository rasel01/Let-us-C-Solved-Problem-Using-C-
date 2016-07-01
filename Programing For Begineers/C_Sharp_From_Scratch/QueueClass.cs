using System;
using System.Collections.Generic;

namespace C_Sharp_From_Scratch
{
    public class QueueClass
    {
        public void DeclareQueue()
        {
            Queue<int> queue1 = new Queue<int>();
            queue1.Enqueue(100);
            int check = queue1.Dequeue();
            Console.WriteLine("last queue value is :{0}", check);
        }

        public void AddRemoveValueQueue()
        {
            Queue<int> queueobj = new Queue<int>();
            // add value to queue :
            Console.WriteLine("\n" + "add value to queue" + "\n");
            for (int i = 0; i < 5; i++)
            {
                queueobj.Enqueue(i);

                Console.WriteLine(i);
            }
            // display the adding values :
            Console.WriteLine("\n" + "display the adding values" + "\n");
            foreach (int q in queueobj)
            {
                Console.WriteLine("{0}", q);
            }

            // check the  last dequeu value :
            var lastDeque = queueobj.Dequeue();
            Console.WriteLine("last Dequeue value :{0}", lastDeque);
            lastDeque = queueobj.Dequeue();
            Console.WriteLine("2nd Dequeue value :{0}", lastDeque);
            lastDeque = queueobj.Dequeue();
            Console.WriteLine("third Dequeue value :{0}", lastDeque);
            lastDeque = queueobj.Dequeue();
            Console.WriteLine("forth Dequeue value :{0}", lastDeque);
            lastDeque = queueobj.Dequeue();
            Console.WriteLine("fifth Dequeue value :{0}", lastDeque);

        }
    }
}
