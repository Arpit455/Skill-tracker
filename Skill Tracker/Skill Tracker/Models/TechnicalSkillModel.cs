using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkillTracker.Model
{
    public class TechnicalSkillModel
    {
        public TechnicalSkillModel(int htmlcssjavascript=0, int angular=0, int react=0, int aspdotnetcore=0, int restful=0, int entityframework=0, int git=0, int docker=0, int jenkins=0, int azure=0)
        {
            this.htmlcssjavascript = htmlcssjavascript;
            this.angular = angular;
            this.react = react;
            this.aspdotnetcore = aspdotnetcore;
            this.restful = restful;
            this.entityframework = entityframework;
            this.git = git;
            this.docker = docker;
            this.jenkins = jenkins;
            this.azure = azure;
        }

        [RegularExpression(@"[0-9]+",ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0,20,ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int htmlcssjavascript { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0, 20, ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int angular { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0, 20, ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int react { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0, 20, ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int aspdotnetcore { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0, 20, ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int restful { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0, 20, ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int entityframework { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0, 20, ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int git { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0, 20, ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int docker { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0, 20, ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int jenkins { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Enter a value between 0 and 20 inclusive")]
        [Range(0, 20, ErrorMessage = "The field {0} must be between 0 and 20 inclusive")]
        public int azure { get; set; }


    }
}
