using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_basic_Problem_solve
{
    public class FunctionPointer
    {

        public void DigitSum()
        {
            Console.WriteLine("Enter the  number:");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int res = RecursiveSum(input);
            Console.WriteLine("Using Recursive");
            Console.WriteLine(res);
            sum = Sum(input, sum);
            Console.WriteLine("without recursive");
            Console.Write(sum);
        }

        private int RecursiveSum(int inp)
        {
            if (inp != 0)
            {
                return (inp % 10 + RecursiveSum(inp / 10));
            }
            else
            {
                return 0;
            }
        }

        private int Sum(int input, int sum)
        {
            while (input != 0)
            {
                sum = sum + input % 10;
                input = input / 10;
            }
            return sum;
        }


        public void PrimeFactors()
        {
            Console.WriteLine("Please enter a positive");
            int input = Convert.ToInt32(Console.ReadLine());
            RecursiveFactors(input);
            Console.Write(" * ");

        }

        private void RecursiveFactors(int input)
        {
            for (int i = 2; i <= input; i++)
            {
                if ((input % i) == 0)
                {
                    Console.Write(i);

                    RecursiveFactors(input / i);
                    break;

                }
            }

        }

        public void FibonacciSequce()
        {
            Console.WriteLine("Enter number for limit:");
            int input = Convert.ToInt32(Console.ReadLine());
            WithoutRecursiveFibonacci(input);

        }

        private void WithoutRecursiveFibonacci(int input)
        {
            int first = 1, second = 1, sum = 0;
            Console.Write("{0}  {1}  ", first, second);
            for (int i = 2; i < input; i++)
            {
                sum = first + second;
                Console.Write(" {0} ", sum);
                first = second;
                second = sum;
            }
        }

        public void recursiveFibonacci()
        {
            Console.WriteLine("Enter the length :");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what is first number ?");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = 1, counter = 1;
            recursiveFibonacciMethod(first, second, counter, input);

        }

        private void recursiveFibonacciMethod(int first, int second, int counter, int input)
        {
            if (counter <= input)
            {
                Console.Write(" {0} ", first);
                recursiveFibonacciMethod(second, first + second, counter + 1, input);
            }
        }

        public void InttoBinary()
        {

            Console.WriteLine("enter number");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Binary result :  " + Convert.ToString(input, 2));



        }

        public void sumRecursively()
        {
            Console.WriteLine("Enter how many number you want to sum :");

            int input = Convert.ToInt32(Console.ReadLine());
            int res = recursiveSumValue(input);
            Console.WriteLine("1 to " + input + " Result : " + res);

        }

        private int recursiveSumValue(int input)
        {
            //Console.WriteLine("what is start number?");
            //int f = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            if (input == 1)
            {
                res = 1;

            }
            else
            {
                res = input + recursiveSumValue((input - 1));

            }
            return res;
        }



        public void Circularshift()
        {
            Console.WriteLine("Enter the value of x,y,z :");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            Circular(x, y, z);


        }

        private void Circular(int x, int y, int z)
        {

        }



        public void DecimalToBinary()
        {
            Console.WriteLine("Enter the decimal number :");
            decimal input = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Result is " + Convert.ToString((int)input, 2));


            //Console.WriteLine("Enter the decimal number :");
            //decimal input = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Result is " + Convert.ToString((byte)input, 2));


            //Console.Write("Decimal: ");
            //int decimalNumber = int.Parse(Console.ReadLine());

            //int remainder;
            //string result = string.Empty;
            //while (decimalNumber > 0)
            //{
            //    remainder = decimalNumber % 2;
            //    decimalNumber /= 2;
            //    result = remainder.ToString() + result;
            //}
            //Console.WriteLine("Binary:  {0}", result);
        }


        public void triangleCal()
        {
            Console.WriteLine("enter length a :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter length b :");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter length c :");
            int c = Convert.ToInt32(Console.ReadLine());
            int area = gettriangle(a, b, c);
            Console.WriteLine("Result : " + area);
        }

        private int gettriangle(int a, int b, int c)
        {
            int s;
            s = (a + b + c) / 2;

            int area = s * (s - a) * (s - b) * (s - c);
            return Convert.ToInt32(Math.Sqrt(Convert.ToDouble(area)));
        }

        public void MultipleMetod()
        {
            int distance = DistanceCalculation();
            Console.WriteLine("Distance is : " + distance);

        }

        private int DistanceCalculation()
        {
            int distance = 0;
            Console.WriteLine("Enter how to many axis");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 2)
            {
                distance = DistanceForTwoAxis();

            }
            else if (input == 3)
            {
                distance = DistanceForThreeAxis();
            }

            return distance;
        }

        private int DistanceForThreeAxis()
        {

            Console.WriteLine("Enter point of x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point of x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point of y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point of y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point of z1");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point of z2");
            int z2 = Convert.ToInt32(Console.ReadLine());

            double x = Convert.ToDouble(Math.Pow((x2 - x1), 2));
            double y = Convert.ToDouble(Math.Pow((y2 - y1), 2));
            double z = Convert.ToDouble(Math.Pow((z2 - z1), 2));

            int distance = Convert.ToInt32(Math.Sqrt(x + y + z));
            return distance;
        }

        private static int DistanceForTwoAxis()
        {
            Console.WriteLine("Enter point of x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point of x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point of y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point of y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double x = Convert.ToDouble(Math.Pow((x2 - x1), 2));
            double y = Convert.ToDouble(Math.Pow((y2 - y1), 2));

            int distance = Convert.ToInt32(Math.Sqrt(x + y));
            return distance;
        }

        public void GreatestCommonDivisor()
        {
            Console.WriteLine("Enter number number 1 ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number number 2 ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int res = findGCD(num1, num2);
            Console.WriteLine("Result " + res);
        }

        private int findGCD(int num1, int num2)
        {
            int res = 0;
            if (num2 == 0)
            {
                res = num1;
                return res;
            }
             else if (num1 >= num2 && num2 > 0)
             {
                 res = findGCD(num2, (num1 % num2));

             }

            return res;  

        }
    }
}
