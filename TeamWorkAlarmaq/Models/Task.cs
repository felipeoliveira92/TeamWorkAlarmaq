using System;
using TeamWorkAlarmaq.Enum;

namespace TeamWorkAlarmaq.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //Enum 
        public Status Status { get; set; }
        public DateTime DateInitial { get; set; }
        public DateTime DateEnd { get; set; }
        
        //Id of user that create a Task
        public int UserId { get; set; }
        public User User { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }

    }
}