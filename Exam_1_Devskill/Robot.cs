using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_Devskill
{
    public abstract class Robot
    {
        double speed { get; set; }
        protected int position;
        enum Status
        {
            ON,
            Off
        }

        public abstract void Move(double amount);

    }
}
