namespace TAKI.adi.Models
{
    public class subject
    {
        public int Id { get; set; }
        public int points { get; set; }
        public string teacher { get; set; }
        public bool bagrut { get; set; }

        public List<Students> Students { get; set; } = new();
    }
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public string Teacher { get; set; }
        public bool Bagrut { get; set; }

        public ICollection<Students> Students { get; set; } = new List<Students>();
    }
}
