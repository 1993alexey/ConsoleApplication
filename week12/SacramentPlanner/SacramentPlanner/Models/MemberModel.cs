using System;
namespace SacramentPlanner.Models
{
    public class MemberModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MemberTitleModel MemberTitle { get; set; }

        public MemberModel(string firstName, string lastName, MemberTitleModel memberTitle)
        {
            FirstName = firstName;
            LastName = lastName;
            MemberTitle = memberTitle;
        }
    }
}
