using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesCsharp
{
    internal abstract class Shapes
    {
        protected Location loc;
        public Shapes()
        {
            this.loc = new Location();
        }

        public abstract double Area();
        public abstract double Perimeter();
        public override string ToString()
        {
            return "Shape Class";
        }
    }

    internal class Location
    {
        private double X { get; set; }
        private double Y { get; set; }
    }

    internal class Rectangle : Shapes
    {
        protected double side1;
        protected double side2;

        public Rectangle(double l, double b)
        {
            this.side1 = l;
            this.side2 = b;
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return 2 * (side1 + side2);
        }
    }

    internal class Circle : Shapes
    {
        protected double radius;

        public Circle(int rad)
        {
            this.radius = rad;
        }

        public override double Area()
        {
            return (22.0 / 7) * (this.radius * this.radius);
        }

        public override double Perimeter()
        {
            return 2 * (22.0 / 7) * this.radius;
        }
    }
}
