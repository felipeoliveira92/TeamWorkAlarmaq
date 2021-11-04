namespace TeamWorkAlarmaq.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Description { get; set; } 

        //Id of user that create the comment
        public int UsuarioId { get; set; }
        public User User { get; set; }
        
    }
}