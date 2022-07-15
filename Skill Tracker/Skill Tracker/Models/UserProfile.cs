using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes; 

namespace Skill_Tracker.Models
{
    public class UserProfile
    {
        [BsonId]
        int UserId { get; set; }
        [BsonElement("name")]
        string Name { get; set; }
        [BsonElement("associateid")]
        int AssociateId { get; set; }
        [BsonElement("mobileno")]
        int MobileNo { get; set; }
        [BsonElement("email")]
        string Email { get; set; }

    }
}
