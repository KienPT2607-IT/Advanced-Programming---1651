using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicInheritance
{
    public class TopUpStudent : Student
    {
        public TopUpStudent()
        {
            this.name = "Top-up student";
        }
    }
}