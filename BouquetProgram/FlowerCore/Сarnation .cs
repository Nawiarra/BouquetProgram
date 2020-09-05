using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerCore
{
    public class Сarnation : Flower
    {
        private static double margin = 7;

        private double сarnationPrice;

        public Сarnation(String name, Colors color, double price)
        : base("Сarnation", color, price)
        {
            margin = price * 0.2;
        }

        public override double Price
        {
            get
            {
                return сarnationPrice;
            }
            protected set
            {
                switch (Color)
                {
                    case Colors.Red:
                        {
                            сarnationPrice = value;
                        }
                        break;
                    case Colors.White:
                        {
                            сarnationPrice = value + margin;
                        }
                        break;
                    case Colors.Blue:
                        {
                            сarnationPrice = value + margin * 0.5;
                        }
                        break;
                    case Colors.Green:
                        {
                            сarnationPrice = value + margin * 1.5;
                        }
                        break;
                }
            }
        }
    }
}



