using Skill_Tracker.Models;
using MongoDB.Driver;
using SkillTracker.Model;

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
            var user = _userprofile.Find ( userProfile => userProfile.UserId ==userprofile.UserId ).ToList();
            if (user.Count()==0)
            {
                userprofile.CreatedDate = DateTimeOffset.Now;
                userprofile.LastUpdated = DateTimeOffset.Now;
                _userprofile.InsertOne(userprofile);
                return "User successfully added";
                //_userprofile.ReplaceOne(userProfile => userProfile.UserId == userid, userprofile);
                
            }
            return "User already exist";
        }

        public String  UpdateProfile(int userid, TechnicalSkillModel technicalSkillModel, NonTechnicalSkillModel nonTechnicalSkillModel)
        {
            var user = _userprofile.Find(userProfile => userProfile.UserId == userid).ToList();
            if(user.Count()!=0)
            {
                var filter = Builders<UserProfile>.Filter.Eq("UserId", userid);
                var update = Builders<UserProfile>.Update.Combine(Builders<UserProfile>.Update.Set("TechnicalSkill", technicalSkillModel),
                    Builders<UserProfile>.Update.Set("NonTechnicalSkill", nonTechnicalSkillModel), Builders<UserProfile>.Update.Set("LastUpdated", DateTimeOffset.Now));
                 _userprofile.UpdateOneAsync(filter, update);
                return "User seccessfully updated";
            }
            else
            {
                return "UserId not found";
            }
        }

       public UserProfile FindProfile(int userid)
        {
            var user = _userprofile.Find(userProfile => userProfile.UserId == userid).Single();
            
            return user;
        }
        public List<UserProfile> FilterProfile(string criteria, string criteriaValue)
        {
            criteria = criteria.ToLower();
            criteriaValue = criteriaValue.ToLower();
            if (criteria == "name")
            {
                return (_userprofile.Find(profile => profile.Name.ToLower().StartsWith(criteriaValue))).ToList();
            }
            else if (criteria == "skill")
            {
                if (criteriaValue == "angular")
                {
                    return (_userprofile.Find(profile => profile.TechnicalSkill.angular > 10)).ToList();
                }
                if (criteriaValue == "html")
                {
                    return (_userprofile.Find(profile => profile.TechnicalSkill.htmlcssjavascript > 10)).ToList();
                }
                if (criteriaValue == "react")
                {
                    return (_userprofile.Find(profile => profile.TechnicalSkill.react > 10)).ToList();
                }
                if (criteriaValue == "aspdotnetcore")
                {
                    return (_userprofile.Find(profile => profile.TechnicalSkill.aspdotnetcore > 10)).ToList();
                }
                if (criteriaValue == "restful")
                {
                    return (_userprofile.Find(profile => profile.TechnicalSkill.restful > 10)).ToList();
                }
                if (criteriaValue == "entityframework")
                {
                    return (_userprofile.Find(profile => profile.TechnicalSkill.entityframework > 10)).ToList();
                }
                if (criteriaValue == "git")
                {
                    return (_userprofile.Find(profile => profile.TechnicalSkill.git > 10)).ToList();
                }
                if (criteriaValue == "docker")
                {
                    return (_userprofile.Find(profile => profile.TechnicalSkill.docker > 10)).ToList();
                }
                if (criteriaValue == "jenkins")
                {
                    return (_userprofile.Find(profile => profile.TechnicalSkill.jenkins > 10)).ToList();
                }
                if (criteriaValue == "azure")
                {
                    return (_userprofile.Find(profile => profile.TechnicalSkill.azure > 10)).ToList();
                }
                if (criteriaValue == "spoken")
                {
                    return (_userprofile.Find(profile => profile.NonTechnicalSkill.spoken > 10)).ToList();
                }
                if (criteriaValue == "communication")
                {
                    return (_userprofile.Find(profile => profile.NonTechnicalSkill.communication > 10)).ToList();
                }
                if (criteriaValue == "aptitude")
                {
                    return (_userprofile.Find(profile => profile.NonTechnicalSkill.aptitude > 10)).ToList();
                }
                return new List<UserProfile>();
            }
            else if (criteria == "associateid")
            {
                return (_userprofile.Find(profile => profile.AssociateId.ToLower() == criteriaValue)).ToList();
            }
            return null;
        }
    }
}
