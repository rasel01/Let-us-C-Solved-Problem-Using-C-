using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_basic_Problem_solve
{
    struct Student
    {
        public string RollNumber { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Course { get; set; }
        public string YearOfJoiningDate { get; set; }

        public Student[] TakeInput(Student[] std)
        {
            Console.WriteLine("enter the info");

            for (int i = 0; i < std.Length; i++)
            {
                Console.WriteLine("Enter Student no " + i + " Info ");
                std[i].RollNumber = Console.ReadLine();
                std[i].Name = Console.ReadLine();
                std[i].Department = Console.ReadLine();
                std[i].Course = Console.ReadLine();
                std[i].YearOfJoiningDate = Console.ReadLine();

            }

            return std;


        }

        public void GivenOutput(Student[] std)
        {
            for (int j = 0; j < std.Length; j++)
            {

                if (std[j].YearOfJoiningDate != string.Empty && std[j].RollNumber != string.Empty)
                {
                    Console.WriteLine("Student Roll =" + std[j].RollNumber + Environment.NewLine +
                                      "Student Name = " + std[j].Name + Environment.NewLine +
                                      "Student Department = " + std[j].Department + Environment.NewLine +
                                      "Student Course = " + std[j].Course + Environment.NewLine +
                                      "Student Year of joining =" + std[j].YearOfJoiningDate + Environment.NewLine);
                }
            }
        }
    }

    struct Customer
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public Customer[] TakeInput(Customer[] cus)
        {
            for (int i = 0; i < cus.Length; i++)
            {
                int customerNumber = i + 1;
                Console.WriteLine("Enter Customer no " + customerNumber + " Info ");
                cus[i].AccountNumber = Console.ReadLine();
                cus[i].Name = Console.ReadLine();
                cus[i].Balance = double.Parse(Console.ReadLine());
            }

            return cus;
        }

        public void PrintCustomerInfo(Customer[] cus)
        {
            for (int j = 0; j < cus.Length; j++)
            {

                if (cus[j].Balance > 100)
                {
                    Console.WriteLine("Customer Account Number =" + cus[j].AccountNumber + Environment.NewLine +
                                      "Customer Name =" + cus[j].Name + Environment.NewLine +
                                      "Customer Balance =" + cus[j].Balance + Environment.NewLine
                        );
                }
            }

        }

        public bool UserRequest(string acc, double amount, string req, Customer[] cus)
        {
            bool op = true;
            if (req == "withdrwal" || req == "0")
            {
                for (int i = 0; i < cus.Length; i++)
                {
                    if (cus[i].AccountNumber == acc)
                    {
                        if (amount > cus[i].Balance)
                        {
                            op = false;
                        }
                    }
                }
            }
            return op;
        }


        public void UserTractionRequest(Customer customer, Customer[] cus)
        {
            Console.WriteLine("for diposit press 1" + Environment.NewLine +
                              "for withdrwal press 0" + Environment.NewLine);
            string req = Console.ReadLine();
            if (req == "diposit" || req == "1" || req == "withdrwal" || req == "0")
            {
                Console.WriteLine("enter your account number");
                string acc = Console.ReadLine();
                Console.WriteLine("enter your amount");
                double amount = double.Parse(Console.ReadLine());
                bool op = customer.UserRequest(acc, amount, req, cus);
                if (op == false)
                {
                    if (req == "diposit" || req == "1")
                    {
                        Console.WriteLine("diposit failed");
                    }
                    else
                    {
                        Console.WriteLine("The balance is insufficient for specified withdrawal");
                    }
                }
            }
            else
            {
                Console.WriteLine("invalid request");
            }
        }
    }

    struct Employee
    {
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public DateTime YearOfJoining { get; set; }



        public Employee[] TakeInput(Employee[] emp)
        {
            Console.WriteLine("enter the info");

            for (int i = 0; i < emp.Length; i++)
            {
                int empno = i + 1;
                Console.WriteLine("Enter Employ no " + empno + " Info ");
                emp[i].EmployeeCode = Console.ReadLine();
                emp[i].EmployeeName = Console.ReadLine();
                emp[i].YearOfJoining = new DateTime(Convert.ToDateTime(Console.ReadLine()).Year);
            }

            return emp;
        }

        public void EmployeeOutput(Employee[] emp, DateTime userInput )
        {
            for (int i = 0; i < emp.Length; i++)
            {

                string date = userInput.Year.ToString();
                if (Convert.ToInt32(emp[i].YearOfJoining.Year.ToString()) - Convert.ToInt32(date) == 3)
                {
                    Console.WriteLine("Employee Name " + emp[i].EmployeeName);
                }

            }
        }

    }

}   

       
    