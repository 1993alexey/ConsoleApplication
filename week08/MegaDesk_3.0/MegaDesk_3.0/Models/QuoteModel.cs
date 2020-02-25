using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MegaDesk_3._0.Models
{
    public class QuoteModel
    {
        public int ID { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public int Rush { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public DesktopMaterial MaterialType { get; set; }

        public List<string> MaterialTypes { 
            get { return GetMaterialTypes(); }
        }

        public DateTime SetTimestamp()
        {
            Date = DateTime.Now;
            return Date;
        }

        public int GetSize()
        {
            Size = Width * Depth;
            return Size;
        }

        public decimal GetPrice()
        {
            double size = GetSize();
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

            return Convert.ToDecimal(basePrice + surfacePrice + drawersPrice + materialPrice);
            //return Convert.ToDecimal(basePrice);
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
