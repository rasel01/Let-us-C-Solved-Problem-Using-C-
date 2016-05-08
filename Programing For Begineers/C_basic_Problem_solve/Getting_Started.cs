using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace C_basic_Problem_solve
{
    public class Getting_Started
    {
        public void GrossSalaryCalculation()
        {
            Console.WriteLine("------- Gross Salary Calculation-------------------");
            Console.WriteLine("Formula" + "  " +
                              "gross= basic + other ");
            Console.WriteLine("Please write your basic salary: ");
            decimal basic = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("we give your:" +
                              "rent 20% and dearness allownce 40% of your salary ");
            decimal rent = Convert.ToDecimal((basic * 20) / 100);
            decimal dear = Convert.ToDecimal((basic * 40) / 100);
            decimal gross = basic + rent + dear;
            Console.WriteLine("so your gross salary: " + gross);
            Console.WriteLine("Thanks");

        }

        public void DistanceConverter()
        {
            Console.WriteLine("---------------- convert km to meter,feet,inches,centemeters");
            Console.WriteLine("Please input the distance in km");
            decimal disInKm = Convert.ToDecimal(Console.ReadLine());
            decimal meter = disInKm * 1000;
            decimal inches = meter * 12;
            decimal cent = meter * 100;

            Console.WriteLine("In meter" + meter + " " +
                              " In inch" + inches + " " +
                              " In centermeter" + cent + " ");
        }

        public void MarksCalculation()
        {
            Console.WriteLine("------------Result calculation--------------");
            int temp = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter your subject" + i + " marks");
                int input = Convert.ToInt32(Console.ReadLine());
                if ((input > 100) && (input > 0))
                {
                    Console.WriteLine("you did wrong");
                }

                else
                    temp = temp + input;
            }

            Console.WriteLine("your result is " + temp + " out of 500");
            int percentage = 0;
            percentage = (temp * 100) / 500;
            Console.WriteLine("your percentage is " + percentage);
        }

        public void Interchange()
        {

            Console.WriteLine("Inter Change the value between two number");
            string a = string.Empty;
            string b = string.Empty;
            string c = string.Empty;

            Console.WriteLine("Enter  first number:");
            a = Console.ReadLine();
            Console.WriteLine("Enter  second number:");
            b = Console.ReadLine();

            if (a != string.Empty || b != string.Empty)
            {

                c = a;
                a = b;
                b = c;
                Console.WriteLine(" Now  first number = " + a + " and  second number = " + b);
            }


        }

        public void TempreatureConverter()
        {
            Console.WriteLine(" Convert the tempreture from farenheit to centrigrade");
            Console.WriteLine(" write the temp in Farenheit: ");
            double input = 0;
            double output = 0;
            Console.WriteLine("  formula: c/5 = f-32/9  ");
            input = Convert.ToDouble(Console.ReadLine());
            output = 5 * ((input - 32) / 9);
            Console.WriteLine("Temp  in Centigrade:" + output);
        }




        public void AreaReletedCalculation()
        {
            Console.WriteLine(" --- find area,perimeter of rectangle and area , circumference of circle ");
            double Reclen, Recbreadth;
            double radius;
            Console.WriteLine("formula -> rectagular: area = breadth/length , width = area/length, perimeter = 2*(width + length) " + "" +
                              "area = radius ^ 2 , circumference = 2*pi*radius");

            Console.WriteLine("write the length of rectangular: ");
            Reclen = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("write the breadth of rectangular: ");
            Recbreadth = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("write the radius of circle: ");
            radius = Convert.ToDouble(Console.ReadLine());

            double Recarea, Recperimeter, Recwidth, Carea, Ccircumference;

            Recarea = Recbreadth / Reclen;
            //Recwidth = Recarea/Reclen;
            Recperimeter = 2 * (Reclen + Recbreadth);

            Console.WriteLine("Rectangular area =" + Recarea + " and perimeter" + Recperimeter);

            Carea = radius * radius;
            Ccircumference = 2 * 3.1416 * radius;

            Console.WriteLine("Radius area = " + Carea + "  and Circumference " + Ccircumference);





        }

        public void SumDigit()
        {
            Console.WriteLine("digit of number is calculation: ");
            Console.WriteLine("enter your number:");
            int input = Convert.ToInt32(Console.ReadLine());
            int length = input.ToString().Length;

            //  dynamically:
            int sum = 0;
            while (input != 0)
            {

                sum = sum + input % 10;
                input = input / 10;
            }

            Console.WriteLine("Sum  of digit of your number:" + sum);



            // manually

            //if (length <= 5)
            //{

            //    // 12345 

            //    int value_five = input % 10;  // 5

            //    int removeLast = input / 10;  // 1234

            //    int value_four = removeLast % 10; // 4

            //    int removeLastSecond = removeLast / 10; // 123

            //    int value_third = removeLastSecond % 10; // 3

            //    int removeLastThird = removeLastSecond / 10; // 12

            //    int value_second = removeLastThird % 10; // 2

            //    int value_first = removeLastThird / 10; //1

            //    int sum_digit = value_first + value_second + value_third + value_four + value_five;

            //    Console.WriteLine("your number sum is :" + sum_digit);

            //}
            //else
            //{
            //    Console.WriteLine("Sorry , you entered number is over than 5");
            //}

        }


        public void reversenumber()
        {

            Console.WriteLine("find reverse number");
            Console.WriteLine("enter number");
            int input = Convert.ToInt32(Console.ReadLine()); // 12345
            int reverse = 0;
            while (input > 0)
            {
                // first :
                //  reverse = 5
                // input = 1234

                // second

                // reverse  = 5 * 10 + 4 = 54
                // input = 123

                // third
                // reverse  = 54 * 10 + 3 = 543
                // input = 12

                // four

                // resvers = 543 * 10 + 2  = 5432
                // input = 1

                // fifth = 5432 * 10 + 1 = 54321
                // input = 0
                reverse = reverse * 10 + input % 10;
                input = input / 10;

            }

            Console.WriteLine("you number in reverse mode:" + reverse);
        }


        public void FewDigitSum()
        {
            Console.WriteLine(" sum the 1st and last digit of number");
            Console.WriteLine("Enter your number");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            // check input is greater than 2 digit
            if (input > 10)
            {
                sum = sum + input % 10;


            }
            // find the first digit:

            while (input >= 10)
            {
                input = input / 10;
            }

            sum = sum + input;

            Console.WriteLine("Sum of first and last digit of your number" + sum);
        }


        public void PopulationCalculation()
        {
            int man, women, total_pop, totalLit;
            total_pop = 800000;
            Console.WriteLine("Total Population " + total_pop);
            totalLit = (48 * total_pop) / 100;
            man = (35 * total_pop) / 100;
            women = totalLit - man;
            Console.WriteLine("Total Literate people no: " + totalLit);
            Console.WriteLine("Man Literate no : " + man);
            Console.WriteLine("Women Literate no : " + women);



        }

        public void NotesDistributed()
        {

            int tentk, fiftytk, hundredtk;
            int countten = 0, countfifty = 0, counthundred = 0;
            int input = 0;
            Console.WriteLine("Please enter how much you want to windrawn: ");
            input = Convert.ToInt32(Console.ReadLine());
            while (input >= 0)
            {
                
                //if (input % 10 == 0)
                //{
                //    countten = countten + 1;
                //    input = input - 10;
                //    if (input % 50 == 0)
                //    {
                //        countfifty = countfifty + 1;
                //        input = input - 50;
                //        if (input % 100 == 0)
                //        {
                //            counthundred = counthundred + 1;
                //            input = input - 100;
                //        }
                //        else
                //        {
                //            Console.WriteLine(" input is less then 100");
                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine(" input is less then 100");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine(" input is less then 100");
                //}



                //if (input % 100 == 0)
                //{
                //    counthundred = counthundred + 1;
                //    input = input - 100;
                //}
                ////else
                ////{
                ////    Console.WriteLine(" input is less then 100");
                ////}

                //if (input % 50 == 0)
                //{
                //    countfifty = countfifty + 1;
                //    input = input - 50;
                //}
                ////else
                ////{
                ////    Console.WriteLine(" input is less then 50");
                ////}
                //if (input % 10 == 0)
                //{
                //    countten = countten + 1;
                //    input = input - 10;
                //}
                ////else
                ////{
                ////    Console.WriteLine(" input is less then 10");
                ////}

               
            }

            Console.WriteLine("Ten Taka  :" + countten *10 );
            Console.WriteLine("Fifty Taka  : " + countfifty * 50);
            Console.WriteLine("Hundred Taka :" + counthundred * 100);
            //tentk = countten;
            //fiftytk = countfifty;
            //hundredtk = counthundred;

            //Console.WriteLine("Ten Notes go: " + te);

        }

        public void CostCalculation()
        {
            Console.WriteLine("Enter seeling price of 15 items: ");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            double item0 = Convert.ToDouble(parts[0]);
            double item1 = Convert.ToDouble(parts[1]);
            double item2 = Convert.ToDouble(parts[2]);
            double item3 = Convert.ToDouble(parts[3]);
            double item4 = Convert.ToDouble(parts[4]);
            double item5 = Convert.ToDouble(parts[5]);
            double item6 = Convert.ToDouble(parts[6]);
            double item7 = Convert.ToDouble(parts[7]);
            double item8 = Convert.ToDouble(parts[8]);
            double item9 = Convert.ToDouble(parts[9]);
            double item10 = Convert.ToDouble(parts[10]);
            double item11 = Convert.ToDouble(parts[11]);
            double item12 = Convert.ToDouble(parts[12]);
            double item13 = Convert.ToDouble(parts[13]);
            double item14 = Convert.ToDouble(parts[14]);
            Console.WriteLine("Enter Total Profit :");
            double profit = Convert.ToDouble(Console.ReadLine());
            double total_sell = item0 + item1 + item2 + item3 + item4 + item5 + item6 + item7 + item8
                                + item9 + item10 + item11 + item12 + item13 + item14;
            double total_cost = total_sell - profit;
            double per_item_cost = total_cost / 15;
            Console.WriteLine("Profit" + profit);
            Console.WriteLine("Total sell :" + total_sell);
            Console.WriteLine("Total cost :" + total_cost);
            Console.WriteLine("Cost for Per item is :" + per_item_cost);



        }








    }
}
