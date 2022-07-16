using Skill_Tracker.Models;
using MongoDB.Driver;

namespace Skill_Tracker.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<UserProfile> _userprofile;

        public UserService(ISkillTrackerDatabaseSetting setting,IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(setting.DatabaseName);
            _userprofile = database.GetCollection<UserProfile>(setting.UserProfileCollectionName);
        }
        public string AddProfile(UserProfile userprofile)
        {
            _userprofile.InsertOne(userprofile);
            return "User successfully added";
        }

        public String  UpdateProfile(int userid)
        {
            var user = _userprofile.Find(userProfile => userProfile.UserId == userid);
            if(user!=null)
            {
               // _userprofile.ReplaceOne(userProfile => userProfile.UserId == userid, userid);
                return "Done";
            }
            else
            {
                return "UserId not found";
            }
        }
    }
}
