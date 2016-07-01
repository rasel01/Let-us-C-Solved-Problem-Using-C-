using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_From_Scratch
{
    public abstract class AbstractClasses
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        private DateTime Hiredate { get; set; }

        public virtual void HireDate()
        {
            Hiredate = DateTime.Now;
        }

        public abstract void RaiseMethod();
    }
}
