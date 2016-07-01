using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_basic_Problem_solve
{
    class Program
    {
        static void Main(string[] args)
        {

            Getting_Started gs = new Getting_Started();
            //gs.GrossSalaryCalculation();
            // gs.DistanceConverter();
            // gs.MarksCalculation();

            // gs.Interchange();
            //gs.TempreatureConverter();
            // gs.AreaReletedCalculation();
            // gs.SumDigit();
            //gs.reversenumber();
            // gs.FewDigitSum();
            //gs.PopulationCalculation();
            // gs.NotesDistributed();

            //  gs.CostCalculation();

            Decision_Control_Structure dcs = new Decision_Control_Structure();
            //dcs.ProfitLossDefine();
            //dcs.OddEvenNumber();
            // dcs.LeapYearDefine();
            //dcs.NumberCheckEqualOrNot();

            // dcs.GetYoungerInAge();
            //dcs.CheckValidTriangle();
            //dcs.GetAbsulateValue();
            //dcs.RectangleVsPerimeter();
            // dcs.FindPointInStraightLine();
            //  dcs.FindPointInCircle();
            //  dcs.PointOfStraightLine();
            //dcs.LeapYearOperator();
            // dcs.gradeRequirement();
            // dcs.LibraryFine();
            //dcs.CheckTriangle();
            //dcs.TypeOfTriangle();
            //dcs.WorkTimeline();
            //dcs.OnlineOrderSystem();

            LoopControlStructure lcs = new LoopControlStructure();
            //lcs.OverTimePayment();
            //lcs.FactorialValue();
            //lcs.ArmstrongNumber();
            //lcs.MatchStickGame();
            // lcs.userInput();

            // lcs.FindRangeOfNumberSet();
            //lcs.FindPrimeNumber();
            //lcs.smilePrintScreen();
            //lcs.SeriesSum();
            // lcs.CombinationPrint();
            //lcs.HumanIntelegenceFormula();
            //lcs.starPrint_Square();
            //lcs.MultiplicationTable();

            //lcs.InterestCalculation();


            CaseControlStructure ccs = new CaseControlStructure();
            //ccs.SimpleProgramsWithMenuOption();

            //ccs.GraceMarksFinder();

            //ccs.readReadlineWriteWriteline();


            FunctionPointer fp = new FunctionPointer();
            //fp.DigitSum();
            //fp.PrimeFactors();
            //fp.FibonacciSequce();
            //fp.recursiveFibonacci();
            // fp.InttoBinary();

            //fp.sumRecursively();

            //fp.Circularshift();
            //fp.DecimalToBinary();

            //fp.triangleCal();
            // fp.MultipleMetod();
            // fp.GreatestCommonDivisor();

            Arrays array = new Arrays();
            //array.searchNumber();
            //array.BubbleSort();
            //array.InsertionSort();
            //array.SelectionSort();

            // array.CheckNumber();
            // array.InterChangeNumber();

            //array.DeclareTwoDimension();
            //array.TransposeMatrix();
            //array.LargestNumnberOfMatrix();
            // array.SymanticsMatrix();
            // array.SumOfMatrix();
            //array.MeanDeviation();
            //array.AreaTriangle();

            //array.FindDistanceOfTenCordinate();


            PuppetingOnString pos = new PuppetingOnString();
            //pos.ExtractedString();
           // pos.StringSwap();
           // pos.ArrayStringSort();
           // pos.ArrayStringReverse();
            //pos.removeVowel();
            //pos.optinalParameter();

           //------------------------- structure------------------------//

            //Console.WriteLine("enter the number of  students information  you need to store ?");
            //int input = Convert.ToInt32(Console.ReadLine());
            //Student[] std = new Student[input];
            //if (input <= 450)
            //{
            //    Student st = new Student();
            //    std = st.TakeInput(std);
            //    if (std != null)
            //    {
            //        Console.WriteLine(" Student info are:");
            //        st.GivenOutput(std);
            //    } 
            //}
            //else
            //{
            //    Console.WriteLine("Sorry student info is fill up");
            //}



            //Console.WriteLine("enter the number of  Customer information  you need to store ?");
            //int input = Convert.ToInt32(Console.ReadLine());
            //Customer[] cus = new Customer[input];
            //if (input <= 200)
            //{
            //    Customer customer = new Customer();
            //    cus = customer.TakeInput(cus);
            //    if (cus != null)
            //    {
            //        Console.WriteLine(" Customer info are:");
            //        customer.PrintCustomerInfo(cus);
            //        Console.WriteLine("Any request, then press y for yes or n for no");
            //        string user = Console.ReadLine();
            //        if (user == "yes" || user == "no"|| user == "y" || user == "n" )
            //        {
            //            if (user == "no" || user == "n")
            //            {
            //                Console.WriteLine("ok, goodbye");
            //            }
            //            else
            //            {
            //                customer.UserTractionRequest(customer, cus);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("invalid response from user");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sorry customer number is fill up");
            //}



            Console.WriteLine("How many you have?");
            int input = Convert.ToInt32(Console.ReadLine());
            Employee[] emp = new Employee[input];
            Employee employee= new Employee();
            emp = employee.TakeInput(emp);
            Console.WriteLine("Enter current date");
            DateTime info = Convert.ToDateTime(Convert.ToDateTime(Console.ReadLine()).ToString("yy-mm-dd"));
            employee.EmployeeOutput(emp, info);
            





            Console.ReadKey();

        }

       
    }
}
