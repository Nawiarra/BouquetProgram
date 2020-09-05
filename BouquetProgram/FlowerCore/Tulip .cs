using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerCore
{
    public class Tulip : Flower
    {
        private static double margin = 3;

        private double tulipPrice;

        public Tulip(String name, Colors color, double price)
        : base("Tulip", color, price)
        {
            margin = price * 0.3;
        }

        public override double Price
        {
            get
            {
                return tulipPrice;
            }
            protected set
            {
                switch (Color)
                {
                    case Colors.Red:
                        {
                            tulipPrice = value;
                        }
                        break;
                    case Colors.White:
                        {
                            tulipPrice = value + margin;
                        }
                        break;
                    case Colors.Blue:
                        {
                            tulipPrice = value + margin * 1.5;
                        }
                        break;
                    case Colors.Green:
                        {
                            tulipPrice = value + margin * 2;
                        }
                        break;
                }
            }
        }
    }
}
