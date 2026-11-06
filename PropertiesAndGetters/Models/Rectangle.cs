using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesAndGetters.Models
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Właściwości obliczane do odczytu
        public double Area => Width * Height;
        public double Perimiter => 2 * (Width + Height);
        public bool IsSquare => Width == Height;

        //a2 + b2 = c2 => c = sqrt(a2 + b2)
        public double Diagonal => Math.Sqrt(Width * Width + Height * Height);

        //public double GetArea()
        //{
        //    return Width * Height;
        //}
    }
}
