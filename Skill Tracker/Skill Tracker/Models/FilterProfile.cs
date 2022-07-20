using SkillTracker.Model;

namespace Skill_Tracker.Models
{
    public class FilterProfile
    {
        public FilterProfile(string name, string associateid, string mobile, string email, TechnicalSkillModel technicalskill, NonTechnicalSkillModel nontechnicalskill)
        {
            this.name = name;
            this.associateid = associateid;
            this.mobileno = mobile;
            this.email = email;
            this.technicalskill = technicalskill;
            this.nontechnicalskill = nontechnicalskill;
        }

        public string name { get; set; }
        public string associateid { get; set; }
        public string mobileno { get; set; }
        public string email { get; set; }
        public TechnicalSkillModel technicalskill { get; set; }
        public NonTechnicalSkillModel nontechnicalskill { get; set; }
    }
}
