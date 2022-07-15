namespace Skill_Tracker.Models
{
    public interface ISkillTrackerDatabaseSetting
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string UserProfileCollectionName { get; set; } 
    }
}
