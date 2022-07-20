using Microsoft.AspNetCore.Mvc;
using Skill_Tracker.Models;
using Skill_Tracker.Services;
using SkillTracker.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Skill_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userservice;
        

        public UserController(IUserService userservice)
        {
            this.userservice = userservice;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void AddProfile([FromBody] UserProfile userprofile)
        {
            userservice.AddProfile(userprofile);
        }
        [HttpPut]
        [Route("update-profile/{id}")]
        public string put(int id, Mergeskills mergeskill)
        {
            var result = userservice.FindProfile(id);
            if (result == null)
            {
                return "user id is not found";
            }

            if (result.LastUpdated.AddDays(10) > DateTimeOffset.UtcNow)
            {
                return "wait 10 days before updating the profile again";
            }
            userservice.UpdateProfile(id, mergeskill.technicalSkill, mergeskill.nontechnicalSkill);

            return "updated successfully";
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
