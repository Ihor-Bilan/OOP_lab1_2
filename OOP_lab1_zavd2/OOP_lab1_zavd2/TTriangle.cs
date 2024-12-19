using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1_zavd2
{
    internal class TTriangle
    {
        private double side1, side2, side3;
        public TTriangle()
        {
            side1 = 1;
            side2 = 1;
            side3 = 1;
        }
        public TTriangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new Exception("The side may be positive");
            };
            if (!IsExist(side1, side2, side3))
            {
                throw new Exception("TTriangle");

            }
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public bool IsExist(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1);

        }

        public double Side1
        {
            get { return side1; }
            set
            {
                if (IsExist(value, side2, side3))
                { side1 = value; }
                else
                {
                    throw new Exception("Bad side");
                }

            }
        }
        public double Side2
        {
            get { return side2; }
            set
            {
                if (IsExist(side1, value, side3))
                { side2 = value; }
                else
                {
                    throw new Exception("Bad side");
                }

            }
        }
        public double Side3
        {
            get { return side3; }
            set
            {
                if (IsExist(side1, side2, value))
                { side3 = value; }
                else
                {
                    throw new Exception("Bad side");
                }

            }
        }
         
       public TTriangle(TTriangle other)
        {
            this.side1 = other.side1;
            this.side2 = other.side2;
            this.side3 = other.side3;
        }

        public override string ToString()
        {
            return $"Other triangle sides: side1 = {side1}, side2 = {side2}, side3 = {side3}";
        }

        public bool Equals(TTriangle other)
        {
            if (other == null) return false; 
            return Side1 == other.Side1 && Side2 == other.Side2 && Side3 == other.Side3;
        }


        public double Perimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }

        public double Square(double side1, double side2, double side3)
        {
            return Math.Sqrt(((side1 + side2 + side3) / 2) * (((side1 + side2 + side3) / 2) - side1) * (((side1 + side2 + side3) / 2) - side2) * (((side1 + side2 + side3) / 2) - side3));
        }


    }
}


   
