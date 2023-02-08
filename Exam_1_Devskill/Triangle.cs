using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Exam_1_Devskill
{
    public class Triangle : IShape
    {
        double height { get; set; }
        double width { get; set; }

        double IShape.CalculateArea()
        {
            return .5 * height * width;
        }

        double IShape.CalculatePerimeter()
        {
            return height + width + (.3 * (height+width));
        }

        void IShape.show(double x, double y)
        {
            Console.WriteLine("The area of circle : " + x);
            Console.WriteLine("The perimeter of circle : " + y);
        }
    }
}
