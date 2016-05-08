using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace C_basic_Problem_solve
{
    public class LoopControlStructure
    {
        public void OverTimePayment()
        {
            Console.WriteLine(" Enter how many worker in your company");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter what is time limit for daily working of workers");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  daily working  time of workers");
            int worktime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter what is the rate for overtime pay price for worker");
            double perrate = Convert.ToInt32(Console.ReadLine());

            int overtime = 0;
            double overtimepay = 0;
            for (int i = 1; i <= input; i++)
            {
                if (worktime > limit)
                {
                    overtime = worktime - limit;
                    overtimepay = (perrate * overtime);


                }
            }
            Console.WriteLine("overtime pay price is " + overtimepay + "For per hour");

        }

        public void FactorialValue()
        {
            Console.WriteLine("Enter the number for factorial value");
            int input = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            int intial = 1;
            //while (intial <= input)
            //{
            //    counter =  counter * intial;
            //    intial++;
            //}

            for (int i = 1; i <= input; i++)
            {
                counter = counter * i;
            }
            Console.WriteLine(counter);


        }

        public void AsciiValuePrint()
        {
            int input = 0;
            while (input <= 0)
            {


            }
        }

        public void ArmstrongNumber()
        {
            Console.WriteLine("Enter minimum range");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max range");
            int max = Convert.ToInt32(Console.ReadLine());
            int sum, temp, r;
            for (int i = min; i <= max; i++)
            {
                sum = 0;
                temp = i;
                while (temp != 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    sum = sum + (r * r * r);
                }
                if (sum == i)
                {
                    Console.WriteLine("Armstrong number between" + min + " and " + max + ":" + i);

                }

            }

        }

        public void MatchStickGame()
        {
            Console.WriteLine("------------------- MatchStick game-----------------");
            Console.WriteLine("Computer gives your MatchSticks number:");
            int matchsticks = Convert.ToInt32(Console.ReadLine());
            int computer, user;
            while (matchsticks >= 1)
            {
                Console.WriteLine("Number of matchsticks available right now is " + matchsticks);
                Console.WriteLine("Player can choose maximum 4 match stick like 1,2,3,4");
                user = Convert.ToInt32(Console.ReadLine());
                if (user > 4)
                {
                    Console.WriteLine(" Invalid Taken number , only can take maximum 4");
                    break;
                }
                computer = 5 - ((user == 0) ? 0 : user);
                Console.WriteLine("Computer turns:");
                computer = Convert.ToInt32(Console.ReadLine());
                matchsticks = matchsticks - user - computer;
                continue;
                if (matchsticks == 1)

                    break;


            }
            matchsticks--;

            Console.WriteLine("Computer wins");






        }

        public void userInput()
        {
            string mess;
            Console.WriteLine("Enter number like positive,negitive,zeros");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you want to give  more input then press y , otherwise press n ");
            mess = Console.ReadLine();
            int countPos = 0, countNeg = 0, countZero = 0;
            while (mess != "n")
            {


                if (input > 0)
                {
                    countPos++;
                }
                else if (input == 0)
                {
                    countZero++;
                }
                else if (input == (-1 * input))
                {
                    countNeg++;
                }
                continue;




                if (mess == "n")
                {
                    break;
                }
            }

            Console.WriteLine(countZero);
            Console.WriteLine(countPos);
            Console.WriteLine(countNeg);




        }

        public void FindRangeOfNumberSet()
        {
            int min = 0;
            int max = 0;
            Console.WriteLine("Enter the range of number ");
            int inputRange = Convert.ToInt32(Console.ReadLine().Length);
            Console.WriteLine("Now the enters the numbers");
            for (int i = 1; i <= inputRange; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > max)
                {
                    max = input;
                }
                if (i == 1)
                {
                    min = input;
                }
                if (input < min)
                {
                    min = input;
                }


            }
            Console.WriteLine("The range is :" + (max - min));


        }

        public void FindPrimeNumber()
        {
            Console.WriteLine("Enter min range");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max range");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                for (int j = (min + 1); j < max; j++)
                {

                    if (j == i)
                    {
                        continue;
                    }
                    if (i % j == 0)
                    {
                        break;
                    }
                    if ((i % j) != 0 && j == (max - 1))
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }


        public void smilePrintScreen()
        {
            Console.WriteLine("Enter how to smile face , you want print here");
            int input = Convert.ToInt32(Console.ReadLine());
            int a = 2;
            for (int i = 0; i < input; i++)
            {
                Console.Write((char)a);
            }

        }


        public void SeriesSum()
        {
            // 1/1! + 2/2!+ 3/3!+.... n/n!


            Console.WriteLine("Enter how much series you want");
            double input = Convert.ToDouble(Console.ReadLine());
            double f = 1; double sum = 0;
            for (int i = 1; i <= input; i++)
            {
                f = f * i;
                sum = sum + (i / f);
            }
            Console.WriteLine("Series sum :" + sum);
        }

        public void CombinationPrint()
        {
            // combination of 1,2,3

            for (int a = 1; a <= 3; a++)
            {
                for (int b = 1; b <= 3; b++)
                {
                    for (int c = 1; c < 3; c++)
                    {
                        if (a == b || b == c || c == a)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Combinations are: " + a, b, c);
                        }
                    }
                }
            }


        }

        public void HumanIntelegenceFormula()
        {
            double i;
            for (double y = 1; y <= 6; y++)
            {
                for (double x = 5.5; x <= 12.5; x = x + .5)
                {
                    i = 2 + (y + (.5 * x));
                    Console.WriteLine("So x " + x);
                    Console.WriteLine("So y " + y);
                    Console.WriteLine("So i " + i);
                }
            }
        }

        public void starPrint_Square()
        {
            Console.WriteLine("Enter How much star you want to see here :");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine("\t");
            }
        }


        public void MultiplicationTable()
        {
            Console.WriteLine("Enter which number you want to see the multiplication table:");
            int input = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            for (int i = input; i <= input; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    total = i*j;
                    Console.WriteLine(  i +"*"+ j + "=" +  total);
                }
            }

        }

        public void InterestCalculation()
        {
            double res;
            Console.WriteLine("Enter the value of rate of interest,principle,years,times");
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("Interest rate:");
                double r = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Interest principle:");
                double p = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How times:");
                double q = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How many years");
                double n = Convert.ToDouble(Console.ReadLine());

                double power = n*q;
                res = p*(1 + (r/q));
                double f_res = Math.Pow(res, power);
                Console.WriteLine("Result: " + f_res );


            }

        }
        

        public void seriesCalculation()
        {
            Console.WriteLine("enter how many series you want to sum here");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    
                }
            }

        }
    }
}

