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
        public Task<UserProfile> AddProfile(UserProfile userprofile)
        {
            _userprofile.InsertOne(userprofile);
            return userprofile;
        }

        public Task<String > UpdateProfile(int userid)
        {
            var user = _userprofile.Find(userProfile => userProfile.userid == userid);
        }
    }
}
