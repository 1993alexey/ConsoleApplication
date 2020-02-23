using System;
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
        public string MaterialType { get; set; }
    }
}
