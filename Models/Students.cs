namespace TAKI.adi.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GradeLevel { get; set; }
        public int SubjectId { get; set; }

        public Subject Subject { get; set; } // Updated to use the consolidated Subject class
    }
}