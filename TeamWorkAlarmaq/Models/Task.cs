namespace TeamWorkAlarmaq.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //Enum 
        public Status Status { get; set; }
        public dateTime DateInitial { get; set; }
        public dateTime DateEnd { get; set; }
        
        //Id of user that create a Task
        public int UserId { get; set; }
        public User User { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }

    }
}