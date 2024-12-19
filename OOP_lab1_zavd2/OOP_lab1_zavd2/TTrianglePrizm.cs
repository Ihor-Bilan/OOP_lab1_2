using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1_zavd2
{
    internal class TTrianglePrism : TTriangle
    {
       
        public TTrianglePrism(double side1, double side2, double side3, double hight) : base(side1, side2, side3)
        {
            if(hight <= 0) 
            throw new Exception("The side may be positive");
        }

        private double hight;
        public double Hight
        {
            get { return hight; }
            set
            {
                if (value > 0)
                {
                    hight = value;
                }

            }


        }

        public new double Square(double side1, double side2, double side3, double hight)
        {
             return base.Square(side1, side2, side3) * hight;
        }

       

    }

}


