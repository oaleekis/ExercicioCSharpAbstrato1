using ExercicioCSharpAbstrato1.Entities.Enums;
using System;

namespace ExercicioCSharpAbstrato1.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
