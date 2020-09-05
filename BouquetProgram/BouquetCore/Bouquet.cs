using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerCore;

namespace BouquetCore
{
    public class Bouquet
    {
        private static List<Flower> usersBouquet = new List<Flower>();

        public static double BouquetPrice { get; private set; } = 0;

        public static void AddFlower(Flower flower)
        {
            usersBouquet.Add(flower);

            BouquetPrice += flower.Price;
        }
        public static string[] ShowAllFlowers()
        {
            string[] FlowersInfo = new string[usersBouquet.Count];

            for (int i = 0; i < usersBouquet.Count; i++)
            {
                FlowersInfo[i] = usersBouquet[i].ToString();
            }

            return FlowersInfo;
        }
        public static void DeleteFlower(Flower flower)
        {
            usersBouquet.Remove(flower);

            BouquetPrice -= flower.Price;
        }
    }
}
