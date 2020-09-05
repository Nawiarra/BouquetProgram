using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerCore
{
    public abstract class Flower
    {
        public String Name { get; protected set; }
        public Colors Color { get; protected set; }
        public abstract double Price { get; protected set; }

        public Flower(String name, Colors color, double price)
        {
            Name = name;
            Color = color;
            Price = price;
        }

        public override string ToString()
        {
            return $"Flower name: {Name}\nColor: {Color}\nPrice:{Price}\n";
        }
    }
    public enum Colors
    {
        Red,
        Green,
        Blue,
        White
    }
}
