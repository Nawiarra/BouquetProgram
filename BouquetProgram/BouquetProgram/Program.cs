using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerCore;
using BouquetCore;

namespace BouquetProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouquet bouquet = new Bouquet();

            Bouquet.AddFlower(new Rose("Rose", Colors.Green, 40.50));
            Bouquet.AddFlower(new Rose("Rose", Colors.Red, 35.50));
            Bouquet.AddFlower(new Tulip("Tulip", Colors.White, 34.50));
            Bouquet.AddFlower(new Tulip("Tulip", Colors.Blue, 24.50));

            Console.WriteLine($"Your bouquet cost: {Bouquet.BouquetPrice} and consist:");
            Console.WriteLine();

            string[] flowers = Bouquet.ShowAllFlowers();

            foreach (string flower in flowers)
            {
                Console.WriteLine(flower);
            }

            Console.ReadKey();
        }
    }
}
