using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_4._1
{
    public class Triangle
    {
        public double first;
        public double second;
        public double third;
        public virtual double ReturnFirstEdge() { return first; }
        //public virtual double GetSide { get; set; }

        public Triangle()
        {
            //first_side = first;
        }
        public Triangle(double first_side, double second_side, double third_side)
        {
            if (first_side > 0 && second_side > 0 && third_side > 0
                && first_side + second_side > third_side
                && second_side + third_side > first_side
                && first_side + third_side > second_side)
            {
                first = first_side;
                second = second_side;
                third = third_side;
            }
            else
                throw new Exception();

        }

        public bool ChangeSide(double first_side, double second_side, double third_side)
        {
            if (first_side > 0 && second_side > 0 && third_side > 0
                && first_side + second_side > third_side
                && second_side + third_side > first_side
                && first_side + third_side > second_side)
            {
                first = first_side;
                second = second_side;
                third = third_side;

                return true;
            }
            return false;
        }

        public double GetPerimeter()
        {
            return first + second + third;
        }

        public virtual List<string> CalculateAngles()
        {
            double asq = Math.Pow(first, 2.0);
            double bsq = Math.Pow(second, 2.0);
            double csq = Math.Pow(third, 2.0);
            var angles = new List<string>();
            double alpha = Math.Acos((bsq + csq - asq) / (2 * second * third));
            double betta = Math.Acos((asq + csq - bsq) / (2 * first * third));
            double gamma = Math.Acos((asq + bsq - csq) / (2 * second * first));
            angles.Add(alpha.ToString() + " radian");  // calculating alpha
            angles.Add(betta.ToString() + " radian");        // calculating betta
            angles.Add(gamma.ToString() + " radian");   // calculating gamma
            return angles;
        }

    }
    public class EquilateralTriangle : Triangle
    {
        public double Area;
        public double GetEdge() => first;
        public double GetArea()
        {
            Area = first * first * Math.Sqrt(3) / 2;
            return Area;
        }
        public override List<string> CalculateAngles() => new List<string> { "60", "60", "60" };
    }
}
