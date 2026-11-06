using System;
using System.Collections.Generic;
using System.Text;
//                                                                            P2
namespace PropertiesAndGetters.Models
{
    public class Point2D
    {
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;
        
        public void MoteBy(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public double Distance(Point2D p) 
        { 
            double dx = X - p.X;
            double dy = Y - p.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

    }
}


//P1 