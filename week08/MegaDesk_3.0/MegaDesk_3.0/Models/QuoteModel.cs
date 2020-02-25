using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MegaDesk_3._0.Models
{
    public class QuoteModel
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public DateTime Date { get; set; }

        [Range(24, 96)]
        [Required]
        public int Width { get; set; }

        [Range(12, 48)]
        [Required]
        public int Depth { get; set; }

        [Range(0, 7)]
        [Required]
        public int Drawers { get; set; }

        [Required]
        public int Rush { get; set; }

        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }

        [DisplayName("Material Type")]
        public DesktopMaterial MaterialType { get; set; }

        [NotMapped]
        private static int[,] RushPrices = new int[3, 3];

        [NotMapped]
        private static string PricesUrl = "https://instructure-uploads.s3.us-east-1.amazonaws.com/account_107060000000000001/attachments/1575908/rushOrderPrices.txt?response-content-disposition=inline%3B%20filename%3D%22cit365_document_rushOrderPrices.txt%22%3B%20filename%2A%3DUTF-8%27%27cit365%255Fdocument%255FrushOrderPrices.txt&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAJDW777BLV26JM2MQ%2F20200225%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20200225T194619Z&X-Amz-Expires=86400&X-Amz-SignedHeaders=host&X-Amz-Signature=2988a6c9a40e72a73983768b2cdd9d80fe60ce013dbfac638f4a09825d4a9dd3";

        public List<string> MaterialTypes { 
            get { return GetMaterialTypes(); }
        }

        public int SetSize()
        {
            Size = Width * Depth;
            return Size;
        }

        public decimal SetPrice()
        {
            double size = SetSize();
            double basePrice = 200;
            double surfacePrice = size > 1000 ? size - 1000 : 0;
            double drawersPrice = Drawers * 50;
            double materialPrice = 0;

            switch (MaterialType)
            {
                case DesktopMaterial.LAMINATE:
                    materialPrice = 100;
                    break;
                case DesktopMaterial.OAK:
                    materialPrice = 200;
                    break;
                case DesktopMaterial.PINE:
                    materialPrice = 50;
                    break;
                case DesktopMaterial.ROSEWOOD:
                    materialPrice = 300;
                    break;
                case DesktopMaterial.VENEER:
                    materialPrice = 125;
                    break;
            }

            Price = Convert.ToDecimal(basePrice + surfacePrice + drawersPrice + materialPrice + GetRushPrice(size));
            return Price;
        }

        public static List<string> GetMaterialTypes()
        {
            var materialTypes = Enum.GetNames(typeof(DesktopMaterial))
                                    .Cast<string>()
                                    .Select(x => {
                                        string str = x.ToString().ToLower();
                                        return char.ToUpper(str[0]) + str.Substring(1);
                                    })
                                    .ToList();
            return materialTypes;
        }


        async public static Task LoadRushPrices()
        {
            // get rush prices
            string priceStr;
            using (HttpClient client = new HttpClient())
            {
                using HttpResponseMessage res = await client.GetAsync(PricesUrl);
                using HttpContent content = res.Content;
                priceStr = await content.ReadAsStringAsync();
            }

            // put prices into a grid
            string[] lines = priceStr.Split("\r\n");
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
    }

    public enum DesktopMaterial
    {
        OAK,
        LAMINATE,
        PINE,
        ROSEWOOD,
        VENEER
    }
}
