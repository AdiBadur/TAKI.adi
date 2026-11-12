namespace TAKI.adi.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Points { get; set; }
        public string? Teacher { get; set; }
        public bool Bagrut { get; set; }

        public ICollection<Students> Students { get; set; } = new List<Students>();
    }
}
