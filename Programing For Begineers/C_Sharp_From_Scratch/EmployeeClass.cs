using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_From_Scratch
{
    public class EmployeeClass
    {
        public void UseAbsTrucedClassForMultiPurpose()
        {
            var Employee1 = new WorkerClass();
            Employee1.Name = "rasel";
            Employee1.Salary = 10000;
            var Employee2 = new ManagerClass();
            Employee2.Name = "Bikash Roy";
            Employee2.Salary = 80000;
            var Employee3 = new WorkerClass();
            Employee3.Name = "konik";
            Employee3.Salary = 30000;

            List<AbstractClasses> Employee = new List<AbstractClasses>();
            Employee.Add(Employee1);
            Employee.Add(Employee2);
            Employee.Add(Employee3);

            foreach (AbstractClasses emp in Employee)
            {
                Console.WriteLine("{0} employee salary is {1}", emp.Name, emp.Salary);
                emp.RaiseMethod();
                Console.WriteLine("Now {0} employee salary is {1}", emp.Name, emp.Salary);
            }
        }
    }
}
