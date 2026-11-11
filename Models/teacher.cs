namespace TAKI.adi.Models
{
    public class teacher
    {
        public int Id { get; set; }
        public int name { get; set; }
        public string gender { get; set; }

        public int roomNumber { get; set; }

        public List<Students> Students { get; set; } = new();
    }
}

