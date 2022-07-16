using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes; 

namespace Skill_Tracker.Models
{
    public class UserProfile
    {
        [BsonId]
        public int UserId { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("associateid")]
       public  int AssociateId { get; set; }
        [BsonElement("mobileno")]
       public int MobileNo { get; set; }
        [BsonElement("email")]
       public string Email { get; set; }

    }
}
