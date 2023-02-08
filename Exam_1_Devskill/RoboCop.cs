using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_Devskill
{
    public class RoboCop : Robot
    {
        int Current_position ;
        public override void Move(double amount)
        {
            Current_position = (int)(position + amount);
        }
    }
}
