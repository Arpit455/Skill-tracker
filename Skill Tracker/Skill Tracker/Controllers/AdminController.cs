using Microsoft.AspNetCore.Mvc;
using Skill_Tracker.Models;
using Skill_Tracker.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Skill_Tracker.Controllers
{
    [Route("api/skilltracker/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IUserService userservice;

        
        public AdminController(IUserService userservice)
        {
            this.userservice = userservice;
        }
        // GET: api/<AdminController>
        [HttpGet]
        [Route("{criteria}/{criteriaValue}")]
        public  ActionResult<List<FilterProfile>> GetFilteredProfile(string criteria, string criteriaValue)
        {
            criteria = criteria.ToLower();
            List<UserProfile> filtered =  userservice.FilterProfile(criteria, criteriaValue);
            if (filtered == null)
            {
                return NotFound("criteria not in database");
            }
            List<FilterProfile> newList = new List<FilterProfile>();
            filtered.ForEach(profile => newList.Add(new FilterProfile(profile.Name, profile.AssociateId, profile.MobileNo, profile.Email, profile.TechnicalSkill, profile.NonTechnicalSkill)));
            return newList;
        }
    }
}
