using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_basic_Problem_solve
{
    public class Decision_Control_Structure
    {
        public void ProfitLossDefine()
        {
            Console.WriteLine("Enter Cost Price :");
            double cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Selling Price: ");
            double sell = Convert.ToDouble(Console.ReadLine());
            double profitLoss = sell - cost;
            if (sell > cost)
            {
                Console.WriteLine("Profit is " + profitLoss);

            }
            else
            {
                Console.WriteLine("Loss is " + ((-1) * profitLoss));

            }
        }

        public void OddEvenNumber()
        {
            Console.WriteLine("Enter your number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine(input + " is Even number");
            }
            else
            {
                Console.WriteLine(input + " is Odd number");

            }
        }

        public void LeapYearDefine()
        {
            //All years which are perfectly divisible by 4 are leap years 
            //except for century years( years ending with 00 ) which is a 
            //leap year only it is perfectly divisible by 400.
            //For example: 2012, 2004, 1968 etc are leap year but, 1971, 2006 etc 
            //are not leap year. Similarly, 1200, 1600, 2000, 2400 are leap years
            //but, 1700, 1800, 1900 etc are not.

            // check with 4
            // check with 100
            // check with 400

            Console.WriteLine("Enter a year :");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {

                    if (year % 400 == 0)
                    {
                        Console.WriteLine(year + " is  leap year ");

                    }
                    else
                    {
                        Console.WriteLine(year + " is not  leap year ");

                    }
                }
                else
                {
                    Console.WriteLine(year + " is  leap year ");
                }
            }
            else
            {
                Console.WriteLine(year + " is not leap year ");
            }

        }


        public void NumberCheckEqualOrNot()
        {
            Console.WriteLine("Please enter your number");
            int input = Convert.ToInt32(Console.ReadLine());
            int reverse = FindReverse(input);
            if (input == reverse)
            {
                Console.WriteLine("Input number" + input + "Reverse Number " + reverse);
                Console.WriteLine("Original and Reverse Number are same");
            }
            else
            {
                Console.WriteLine("Input number" + input + "Reverse Number " + reverse);
                Console.WriteLine("Original and Reverse Number are not  same");

            }
        }

        private int FindReverse(int input)
        {
            int value = input;
            int rev = 0;
            while (value > 0)
            {
                rev = rev * 10 + value % 10;
                value = value / 10;
            }
            return rev;
        }



        public void GetYoungerInAge()
        {
            Console.WriteLine("Please Enter age of Ram :");
            int ageRam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter age of Shayam :");
            int ageShayam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter age of Ajay :");

            int ageAjay = Convert.ToInt32(Console.ReadLine());
            if (ageRam == ageShayam || ageRam == ageAjay || ageShayam == ageAjay)
            {
                Console.WriteLine("Same Age are not possible");
            }
            else
            {
                string younger = (ageRam < ageShayam
                 ? (ageRam < ageAjay ? "Ram" : "Ajay")
                 : (ageShayam < ageAjay ? "Shayam" : "Ajay"));
                Console.WriteLine("Youngst is: " + younger);
            }


        }

        public void CheckValidTriangle()
        {
            Console.WriteLine("Input the first Angle value : ");
            int t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second Angle value : ");
            int t2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third Angle value : ");
            int t3 = Convert.ToInt32(Console.ReadLine());
            int triangle = t1 + t2 + t3;
            Console.WriteLine(triangle == 180 ? "Valid Triangle" : "InValid Triangle");
        }

        public void GetAbsulateValue()
        {
            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32(Console.ReadLine());
            int abs = num < 0 ? (-1) * num : num;
            Console.WriteLine("Absulate vale " + abs);

        }

        public void RectangleVsPerimeter()
        {
            Console.WriteLine("Enter length value :");
            double leng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth value :");
            double breadth = Convert.ToInt32(Console.ReadLine());
            double rectangular = leng * breadth;
            double peri = 2 * (leng + breadth);
            Console.WriteLine(rectangular > peri ? "Rectangular is greater " : "Perimeter is greater");

        }

        public void FindPointInStraightLine()
        {
            Console.WriteLine("Enter x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y3");
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x = findAbsValue(x2 - x1);
            int y = findAbsValue(y2 - y1);
            int z = findAbsValue(x3 - x1);
            int w = findAbsValue(y3 - y1);

            int s1 = x / y;
            int s2 = z / w;
            int s3 = 0;

            Console.WriteLine(s1 == s2 ? "Points are in Line" : "Points are not  in Line");
        }

        private int findAbsValue(int p)
        {

            return (p < 0 ? (-1) * p : p);

        }

        public void FindPointInCircle()
        {
            Console.WriteLine("Enter the Center point for x axis:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Center point for y axis:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the radius of circle:");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Find point for x axis:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Find point for y axis:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            int p = (x1 - x) * (x1 - x) + (y1 - y) * (y1 - y);
            int sqp = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(p)));
            if (sqp > r)
            {
                Console.WriteLine("Point lies outside the circle");
            }
            else
            {
                if (sqp < r)
                {
                    Console.WriteLine("Point lies inside the circle");

                }
                else
                {
                    Console.WriteLine("Point lies on  the line of circle");

                }
            }


        }

        public void PointOfStraightLine()
        {
            Console.WriteLine("Enter value of for x-axis :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of for y-axis :");
            int y = Convert.ToInt32(Console.ReadLine());

            string message = ((x == 0 && y == 0)
                ? "points lies to origin"
                : (x == 0) ? "Points lies on y axis" : (y == 0) ? "Points lies on x axis" : "In the x and y axis");
            Console.WriteLine(message);

        }

        public void LeapYearOperator()
        {
            Console.WriteLine("Enter the year:");
            int input = Convert.ToInt32(Console.ReadLine());
            //string message = ((((input % 4) == 0) && ((input % 100) != 0)) || ((input % 400) == 0))
            //    ? input + " is Leap year "
            //    : input + " is  not Leap year ";

            if ((((input % 4) == 0) && ((input % 100) != 0)) || ((input % 400) == 0))
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine(" Not a Leap year");

            }
        }

        public void gradeRequirement()
        {
            Console.WriteLine("Enter your requirement:");
            Console.WriteLine("Enter hardness of steel:");
            int hardness = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Carbon Content of steel:");
            double Carbon = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Tensile of steel:");
            int Tensile = Convert.ToInt32(Console.ReadLine());
            if (hardness > 50 && Carbon < 0.7 && Tensile > 5600)
            {
                Console.WriteLine("You need Grade 10");
            }
            else if (hardness > 50 && Carbon < 0.7)
            {
                Console.WriteLine("You need Grade 9 ");

            }
            else if (Carbon < 0.7 && Tensile > 5600)
            {
                Console.WriteLine("You need Grade 8 ");

            }

            else if (hardness > 50  && Tensile > 5600)
            {
                Console.WriteLine("You need Grade 7 ");

            }
            else if (hardness > 50 || Carbon < 0.7 || Tensile > 5600)
            {
                Console.WriteLine("You need Grade 6 ");

            }
            else
            {
                Console.WriteLine("You need Grade 5 ");
                    
            }
        }

        public void LibraryFine()
        {
            Console.WriteLine("Enter how many day you late to return the book :");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 0  && input <= 5)
            {
                Console.WriteLine("your late fine is 50 tk");
            }
            else if (input >= 6 && input <= 10)
            {
                Console.WriteLine("your late fine is 100 tk");
                
            }
            else if (input > 10 && input <= 30)
            {
                Console.WriteLine("your late fine is 500 tk");

            }
            else if (input > 30)
            {
                Console.WriteLine("Sorry your Membership is canceled");

            }

        }


        public void CheckTriangle()
        {
            Console.WriteLine("Enter the first side of triangle");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second side of triangle");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third side of triangle");
            int z = Convert.ToInt32(Console.ReadLine());

            if ((((x + y) > z) && (x != y)) || (((x + z) > y) && (x != y)) || (((y + z) > x) && (y != z)))
            {
                Console.WriteLine("Valid triangle");
            }
            else
            {
                Console.WriteLine(" InValid triangle");
                
            }
           
        }

        public void TypeOfTriangle()
        {
            Console.WriteLine("Enter the values of sides of triangle: ");
            Console.WriteLine("First side");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seccond side");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third side");
            int third = Convert.ToInt32(Console.ReadLine());

            if ( first == second && second == third)
            {
                Console.WriteLine("equilateral ");
            }
            else if (first == third || second == third || first == second)
            {
                Console.WriteLine("ISOCELES");
            }
            else if (first != second || second != third || first != third)
            {
                Console.WriteLine("scalene");
            }
            else
            {
                Console.WriteLine("In Valid Triangle");
            }

        }


        public void WorkTimeline()
        {
            Console.WriteLine(" Enter worker time line in hours");
            double input = Convert.ToDouble(Console.ReadLine());
            if (input > 2 && input <= 3)
            {
                Console.WriteLine("Highly efficent");
            }
            else if (input > 3 && input <= 4)
            {
                Console.WriteLine("Improve the speed");
                
            }
            else if (input > 4 && input <= 5)
            {
                Console.WriteLine("Train");

            }
            else if (input > 5)
            {
                Console.WriteLine("you have to leave this company");

            }
        }


        public void OnlineOrderSystem()
        {
            Console.WriteLine("Enter how much you want in quantity:");
            int customer_quantity = Convert.ToInt32(Console.ReadLine());
            int stock = 100;
            double perQuantity = 20.0;
            double shipcost = 10.0;
            double customer_bill = (( perQuantity*customer_quantity) + shipcost);
            Console.WriteLine("your bill total "+ customer_bill);
            Console.WriteLine("Please pay your bill:  ");
            double customer_payment = Convert.ToInt32(Console.ReadLine());
            if ((customer_quantity <= stock) && (customer_bill == customer_payment))
            {
                Console.WriteLine("Supllied");   
            }
            else if (customer_payment != customer_bill)
            {
                Console.WriteLine("Please pay first");   
                
            }
            else if ((customer_bill == customer_payment) && (customer_quantity > stock))
            {
                int remain_quantity = customer_quantity - stock;
                Console.WriteLine("We have to supplied" + stock + "Remain product no  " + remain_quantity + "will be supplied next day. If this is ok for you then press ok: ");
                string confirm = Console.ReadLine();
                if (confirm != null && confirm.Equals("ok") == true)
                {
                    Console.WriteLine("Thanks");
                }
                else
                {
                    Console.WriteLine("Thanks for visiting here . Please visit here again");
                }
            }

        }

    }
}
