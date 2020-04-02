using System;
namespace SacramentPlanner.Models
{
    public class TalkModel
    {
        public string TalkTitle { get; set; }
        public MemberModel Speaker { get; set; }
        public int TimeLimit { get; set; }

        public TalkModel(string talkTitle, MemberModel speaker, int timeLimit)
        {
            TimeLimit = timeLimit;
            Speaker = speaker;
            TalkTitle = talkTitle;
        }

        public TalkModel(){}
    }
}
