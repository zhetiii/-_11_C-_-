using System;

namespace KT_11_Shapes
{
    public class Triangle : IDrawable
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Perimeter() => SideA + SideB + SideC;

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public string Draw()
        {
            return @"    ▲
   ▲▲▲
  ▲▲▲▲▲
 ▲▲▲▲▲▲▲
▲▲▲▲▲▲▲▲▲";
        }
    }
}
