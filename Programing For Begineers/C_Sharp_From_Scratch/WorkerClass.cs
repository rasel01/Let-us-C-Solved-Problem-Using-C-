using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_From_Scratch
{
    public class WorkerClass:AbstractClasses
    {
        public override void RaiseMethod()
        {
            Salary = (Salary + Salary*.3);
        }
    }
}
