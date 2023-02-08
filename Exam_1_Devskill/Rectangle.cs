using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Exam_1_Devskill
{
    public class Rectangle : IShape
    {
        double height { get; set; }
        double width { get; set; }

        double IShape.CalculateArea()
        {
            return height * width;
        }

        double IShape.CalculatePerimeter()
        {
            return 2 * (height + width);
        }

        void IShape.show(double x, double y)
        {
            Console.WriteLine("The area of circle : " + x);
            Console.WriteLine("The perimeter of circle : " + y);
        }
    }
}
