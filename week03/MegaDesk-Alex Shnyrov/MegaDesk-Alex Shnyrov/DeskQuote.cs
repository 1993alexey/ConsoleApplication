using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Alex_Shnyrov
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }
        public int Rush { get; set; }
        public DateTime Date { get; private set; }
        public string Name { get; set; }
        private static int[,] RushPrices = new int[3, 3];
        private static readonly string filePath = "rush-prices.txt";

        public double GetPrice()
        {
            double deskPrice = Desk.GetPrice();
            double rushPrice = GetRushPrice(Desk.GetSize());
            return deskPrice + rushPrice;
        }

        public static void LoadRushPrices()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                int i = 0;
                int j = 0;

                foreach (string line in lines)
                {
                    RushPrices[i, j++] = Int32.Parse(line);

                    if (j == 3)
                    {
                        i++;
                        j = 0;
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Unable to find file \"rush-prices.txt\"");
            }

        }

        private double GetRushPrice(double size)
        {
            if (Rush == 14)
                return 0.0;

            int[] rushIndex = new int[8];
            rushIndex[7] = 0;
            rushIndex[5] = 1;
            rushIndex[3] = 2;

            int i = rushIndex[Rush];

            if (size < 1000)
                return RushPrices[2, i];
            else if (size > 2000)
                return RushPrices[0, i];
            else return RushPrices[1, i];
        }

        public void SetTimestamp()
        {
            Date = DateTime.Now;
        }
    }
}
