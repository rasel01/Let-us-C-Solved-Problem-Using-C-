using System;

namespace C_Sharp_From_Scratch
{
    public class Loops
    {
        public void WhileLoops()
        {
            Console.WriteLine("How old are you ?");
            //int age = Convert.ToInt32(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("HBD" + "\n");
                age -= 1;
            } while (age > 0);

        }
    }
}
