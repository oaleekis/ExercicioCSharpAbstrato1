﻿using ExercicioCSharpAbstrato1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharpAbstrato1.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(Color color, double width, double height) :base(color)
        {
            Width = width; 
            Height = height;
        }

        public override double Area()
        {
           return Width * Height;
        }
    }
}
