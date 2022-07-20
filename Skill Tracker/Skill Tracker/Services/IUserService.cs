using Skill_Tracker.Models;
using SkillTracker.Model;

namespace Skill_Tracker.Services
{
    public interface IUserService
    {
        string AddProfile( UserProfile userprofile);

        UserProfile FindProfile(int userid);

        String UpdateProfile(int userid, TechnicalSkillModel technicalSkillModel, NonTechnicalSkillModel nonTechnicalSkillModel);

        List<UserProfile> FilterProfile(string criteria, string criteriaValue);
    }
}
