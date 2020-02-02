using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Alex_Shnyrov
{
    public class Desk
    {
        public double Width { get; set; }
        public double Depth { get; set; }
        public int Drawers { get; set; }
        public DesktopMaterial Material { get; set; }

        public double GetSize()
        {
            return Width * Depth;
        }
            
        public double GetPrice()
        {
            double size = GetSize();
            double basePrice = 200;
            double surfacePrice = size > 1000 ? size - 1000 : 0;
            double drawersPrice = Drawers * 50;
            double materialPrice = 0;

            switch (Material)
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

            return basePrice + surfacePrice + drawersPrice + materialPrice;
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
