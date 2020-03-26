using System;
namespace SacramentPlanner.Models
{
    public class HymnModel
    {
        public string Title { get; set; }
        public int Number { get; set; }

        public HymnModel(string title, int number)
        {
            Title = title;
            Number = number;
        }
    }
}
