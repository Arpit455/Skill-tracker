using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkillTracker.Model
{
    public class NonTechnicalSkillModel
    {
        public NonTechnicalSkillModel(int spoken=0, int communication=0, int aptitude=0)
        {
            this.spoken = spoken;
            this.communication = communication;
            this.aptitude = aptitude;
        }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0, 20, ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int spoken { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0, 20, ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int communication { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0, 20, ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int aptitude { get; set; }
    }
}
