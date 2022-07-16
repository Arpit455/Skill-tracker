using Skill_Tracker.Models;

namespace Skill_Tracker.Services
{
    public interface IUserService
    {
        string AddProfile( UserProfile userprofile);
        string UpdateProfile(int userid);

    }
}
