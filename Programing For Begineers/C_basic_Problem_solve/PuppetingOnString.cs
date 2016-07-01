using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_basic_Problem_solve
{
    public class PuppetingOnString
    {
        public void ExtractedString()
        {
            Console.WriteLine("Please enter string");
            string sen = Console.ReadLine();
            Console.WriteLine("enter the first point number for the position");
            int pos1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Last point number for the position");
            int pos2 = Convert.ToInt32(Console.ReadLine());

            string remain = sen.Substring(pos1, pos2);
            if (remain.Length == 0)
            {
                Console.WriteLine("After Extraction :" + sen.Substring(pos2,sen.Length));
            }
            else
            {
                Console.WriteLine("After Extraction :" + remain);
            }

        }

        public void StringSwap()
        {
            Console.WriteLine("Enter your main string");
            string main = Console.ReadLine();
            Console.WriteLine("Enter serch string one");
            string stringOne = Console.ReadLine();
            Console.WriteLine("Enter serch string two");
            string stringtwo = Console.ReadLine();

            if (main.Contains(stringOne)== true)
            {
               main= main.Replace(stringOne, stringtwo);
            }
            Console.WriteLine("after replace :" + main);

        }

        public void ArrayStringSort()
        {
           // System.da
            Console.WriteLine(" enter how many word need sorting");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your word for sorting");
            string [] myarray = new string[input];
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = Console.ReadLine();

            }
            Array.Sort(myarray);
            Console.WriteLine(" After sorting");

            foreach (var arr in myarray)
            {
                Console.WriteLine(arr);
            }
            
        }

        public void ArrayStringReverse()
        {
            Console.WriteLine(" enter how many word need sorting");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your word for sorting");
            string[] myarray = new string[input];
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = Console.ReadLine();

            }
            Array.Reverse(myarray);
            Console.WriteLine("After reverse");
            foreach (var a in myarray)
            {
                Console.WriteLine( a);
            }

        }

        public void removeVowel()
        {
            Console.WriteLine("Please enter the sentence");
            string sen = Console.ReadLine();
            string str2 = string.Empty;

            for (int i = 0; i < sen.Length; i++)
            {
                if (sen[i] == 'a'|| sen[i] == 'e' || sen[i] == 'i' || sen[i] == 'o' || sen[i] == 'u'||
                    sen[i] == 'A'|| sen[i] == 'E' || sen[i] == 'I' || sen[i] == 'O' || sen[i] == 'U')
                {
                    
                }

                else
                {
                    str2 = str2 + sen[i];
                }
                
            }
            Console.WriteLine(str2);

        }

        public void optinalParameter()
        {
             AddNumber(10,20,10,10,50);
        }

        private void AddNumber(int i, int j, params object[] numbers)
        {
            int result = i + j;
            if (numbers != null)
            {
                foreach (int n in numbers)
                {
                    result += n;
                }
            }
            Console.WriteLine("Result is =" + result);
        }
    }
}
