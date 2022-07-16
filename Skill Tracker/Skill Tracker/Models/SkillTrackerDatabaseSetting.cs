namespace Skill_Tracker.Models
{
    public class SkillTrackerDatabaseSetting : ISkillTrackerDatabaseSetting
    {
        public string ConnectionString { get; set; }=String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
        public string UserProfileCollectionName { get; set; } = String.Empty;
    }
}
