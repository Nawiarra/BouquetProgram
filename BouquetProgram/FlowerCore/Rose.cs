using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerCore
{
    public class Rose : Flower
    {
        private double margin;

        private double rosePrice;

        public Rose(String name, Colors color, double price)
        : base("Rose", color, price)
        {
            margin = price * 0.5;
        }
        public override double Price
        {
            get
            {
                return rosePrice;
            }
            protected set
            {
                switch (Color)
                {
                    case Colors.Red:
                        {
                            rosePrice = value;
                        }
                        break;
                    case Colors.White:
                        {
                            rosePrice = value + margin;
                        }
                        break;
                    case Colors.Blue:
                        {
                            rosePrice = value + margin * 2;
                        }
                        break;
                    case Colors.Green:
                        {
                            rosePrice = value + margin * 3;
                        }
                        break;
                }
            }
        }
    }
}
