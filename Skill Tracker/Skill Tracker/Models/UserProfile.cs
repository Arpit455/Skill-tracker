using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SkillTracker.Model;
using System.ComponentModel.DataAnnotations;

namespace Skill_Tracker.Models
{
    public class UserProfile
    {
        [BsonId]
        [BsonElement("userid")]
        public int UserId { get; set; }

        [BsonElement("name")]
        [Required]
        [MinLength(5, ErrorMessage = "The minimum length of {0} should be 5")]
        [MaxLength(30, ErrorMessage = "The maximum length of {0} should be 30")]
        public string Name { get; set; } 

        [BsonElement("associateid")]
        [Required]
        [MinLength(5, ErrorMessage = "The minimum length of {0} should be 5")]
        [MaxLength(30, ErrorMessage = "The maximum length of {0} should be 30")]
        [RegularExpression(@"^CTS\w*", ErrorMessage = "The field {0} must start with CTS")]

        public  string AssociateId { get; set; }

        [BsonElement("mobileno")]
        [Required]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "The field {0} must be of 10 characters and only numeric")]
        public string MobileNo { get; set; }

        [BsonElement("email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }


        [BsonElement("technicalskill")]
        public TechnicalSkillModel TechnicalSkill { get; set; }

        [BsonElement("nontechnicalskill")]
        public NonTechnicalSkillModel NonTechnicalSkill { get; set; }

        [BsonElement("createddate")]
        public DateTimeOffset CreatedDate { get; set; }

        [BsonElement("lastupdated")]
        public DateTimeOffset LastUpdated { get; set; }


    }
}
