using System;
namespace SacramentPlanner.Models
{
    public class MemberTitleModel
    {
        public string Title { get; set; }

        public MemberTitleModel(string titleName)
        {
            Title = titleName;
        }
    }
}
