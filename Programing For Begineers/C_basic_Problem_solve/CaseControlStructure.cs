using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_basic_Problem_solve
{
    public class CaseControlStructure
    {

        public void SimpleProgramsWithMenuOption()
        {

            int result;
            string res = string.Empty;
            while (true)
            {
                Console.WriteLine("Write Down Which Program you want:");
                Console.WriteLine("For Factorial Of Number press 1");
                Console.WriteLine("For Prime or not prime press 2");
                Console.WriteLine("For ODD OR EVEN Number press 3");
                Console.WriteLine("For EXIT press 4");
                int choich = Convert.ToInt32(Console.ReadLine());

                switch (choich)
                {
                    case 1:

                        result = FindFactorial();
                        Console.WriteLine(result);
                        break;
                    case 2:

                        res = FindPrimeOrNot();
                        Console.WriteLine(res);
                        break;
                    case 3:

                        res = FindOddOrEven();
                        Console.WriteLine(res);
                        break;
                    case 4:

                        Console.WriteLine("Goodbye");
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Sorry, Invalid Input");
                        //break;
                        break;
                }
            }
        }

        private string FindOddOrEven()
        {
            Console.WriteLine("Enter which number you want to see odd or even");
            int input = Convert.ToInt32(Console.ReadLine());
            string mess = string.Empty;

            if (input % 2 == 0)
            {
                mess = "Even number";
            }
            else
            {
                mess = "Odd number";

            }
            return mess;
        }

        private string FindPrimeOrNot()
        {
            Console.WriteLine("Enter the number which you want to check if is prime or not?");
            int input = Convert.ToInt32(Console.ReadLine());
            string mess = string.Empty;
            for (int i = (input - 1); i > 0; --i)
            {
                if ((input % i == 0) && i != 1)
                {
                    mess = "Composite number";
                    break;

                }
                else
                {
                    if (i == 1)
                    {
                        mess = "Prime Number";
                    }

                }
            }

            return mess;

        }

        private int FindFactorial()
        {
            Console.WriteLine("Enter which number you want factorial");
            int input = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            //int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                f = f * i;

            }
            return f;
        }


        public void GraceMarksFinder()
        {
           
            int fail;
            int grace;
            while (true)
            {
                Console.WriteLine("Enter which class you obtained:");
                Console.WriteLine("For First Class press :1");
                Console.WriteLine("For First Class press :2");
                Console.WriteLine("For First Class press :3");
                Console.WriteLine("Exit press : 4");

                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Congrates ,you get First class");
                        Console.WriteLine("Now enter how many subject you have failed:");
                        fail = Convert.ToInt32(Console.ReadLine());
                        if (fail > 3)
                        {
                            Console.WriteLine("sorry, you have failed" + fail + "Subject , no grace");
                        }
                        else
                        {
                            if (fail <= 3 && fail > 0)
                            {
                                grace = 5;
                                Console.WriteLine("you will get " + grace + "marks as  grace");
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("Congrates ,you get Second class");
                        Console.WriteLine("Now enter how many subject you have failed:");
                        fail = Convert.ToInt32(Console.ReadLine());
                        if (fail > 2)
                        {
                            Console.WriteLine("sorry, you have failed" + fail + "Subject , no grace");
                        }
                        else
                        {
                            if (fail <= 2 && fail > 0)
                            {
                                grace = 4;
                                Console.WriteLine("you will get " + grace + "marks as  grace");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Congrates ,you get Third class");
                        Console.WriteLine("Now enter how many subject you have failed:");
                        fail = Convert.ToInt32(Console.ReadLine());
                        if (fail > 1)
                        {
                            Console.WriteLine("sorry, you have failed" + fail + "Subject , no grace");
                        }
                        else
                        {
                            if (fail <= 1 && fail > 0)
                            {
                                grace = 5;
                                Console.WriteLine("you will get " + grace + "marks as  grace");
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("good bye");
                        System.Environment.Exit(0);
                        break;
                }

            }
        }



        public void readReadlineWriteWriteline()
        {
            Console.WriteLine("enter input :");
            string a = Console.ReadLine();
            int b = Console.Read();
            int r= Convert.ToInt32(Console.Read());
           // int readline = Convert.ToInt32(Console.ReadLine());
            Console.Write("in write method :" + b );
            Console.WriteLine("in writeline method :" +  a);

        }



    }
}
