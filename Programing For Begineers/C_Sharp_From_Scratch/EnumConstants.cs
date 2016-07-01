using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_From_Scratch
{
    public class EnumConstants
    {
        enum Color
        {
            white,
            blue,
            green,
            violet,
            red
        }

        public void EnumuseMethod()
        {
            Color myColor = Color.green;
            switch (myColor)
            {
                case Color.green:
                    Console.WriteLine("Green");
                    break;

                case Color.violet:
                    Console.WriteLine("violet");
                    break;

                case Color.white:
                    Console.WriteLine("white");
                    break;

                case Color.red:
                    Console.WriteLine("red");
                    break;

                case Color.blue:
                    Console.WriteLine("blue");
                    break;

                default:
                    Console.WriteLine("no color");

                    break;
            }
        }
    }
}
