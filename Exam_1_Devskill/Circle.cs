using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Exam_1_Devskill
{
    public class Circle : IShape
    {
        double radius { get; set; }

        double IShape.CalculateArea()
        {
            return 3.14159 * (radius * radius);
        }

        double IShape.CalculatePerimeter()
        {
            return 2 * 3.14159 * radius; 
        }

        void IShape.show(double area, double perimeter)
        {
            Console.WriteLine("The area of circle : " + area );
            Console.WriteLine("The perimeter of circle : " + perimeter);
        }
    }
}
