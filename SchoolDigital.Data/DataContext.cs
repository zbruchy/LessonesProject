using SchoolDigital.Core;
using SchoolDigital.Core.Entities;

namespace SchoolDigital
{
    public class DataContext : IDataContext
    {
        public List<Lesson> lessons { get; set; }
        public List<Attendance> attendances { get; set; }
        public List<Material> materials { get; set; }
        public List<User> users { get; set; }
        public DataContext()
        {
            attendances = new List<Attendance>();

            lessons = new List<Lesson> { new Lesson { Id = 1, Title = "תנך – פרשת השבוע", TeacherId = 1, Date = DateTime.Parse("2025-10-25"), Duration = 90, Description = "לימוד פרשת השבוע" } };

            materials = new List<Material>();

            users = new List<User>() {
            new User { Id = 1, Name = "ישראל כהן", Role = "teacher", Email = "israel@example.com" },
            new User { Id = 2, Name = "שרה לוי", Role = "student", Email = "sara@example.com" }
            };
        }
    }
}
