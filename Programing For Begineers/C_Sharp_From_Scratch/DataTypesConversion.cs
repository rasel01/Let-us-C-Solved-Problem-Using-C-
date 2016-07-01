using System;

namespace C_Sharp_From_Scratch
{
    public class DataTypesConversion
    {

        public void CastMethod()
        {
            Console.WriteLine("Cast method for int to other data type conversion");
            Console.WriteLine("enter a int number");
            float number = (float) 100000890000.434343;
            int fNumber = (int) number;
            Console.WriteLine(fNumber);

        }
        public void ConvertMethod()
        {
            Console.WriteLine("Convert  method can give overflow exception when can't take big number from int");
            Console.WriteLine("enter a int number");
            
            int fNumber = Convert.ToInt32(100000089890000898);
            Console.WriteLine(fNumber);

        }

        public void ParseMethod()
        {
            Console.WriteLine(" int.Parse method for string to int data type conversion and it can give  exception when can't get correct format");
            Console.WriteLine("enter a string number");

            int fNumber = int.Parse("100abc");
            Console.WriteLine(fNumber);

        }

        public void TryParseMethod()
        {
            Console.WriteLine(" int.TryParse method for string to int data type conversion and it can give  bool true when convert the input number other wise gives false");
            Console.WriteLine("enter a string number");
            int res;
            bool fNumber = int.TryParse("100", out res);
            Console.WriteLine(fNumber);

        }

        public void forEverLoop()
        {

            int i = 0;
            for (; ; )
            {
                //Console.WriteLine("forever loop");
                Console.Write("*");
                i++;
            }
        }

        public void ContinueBreakLoop()
        {
            int i = 0;
            for (;; )
            {
                ++i;
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine("count {0}",i);
                if (i > 10)
                {
                   break; 
                }
            }
        }
    }
}
