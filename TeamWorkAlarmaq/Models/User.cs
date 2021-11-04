namespace TeamWorkAlarmaq.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}