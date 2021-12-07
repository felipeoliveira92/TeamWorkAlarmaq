using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeamWorkAlarmaq.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [DisplayName("Titulo")]
        [Required(ErrorMessage ="Campo Requerido!")]
        public string Title { get; set; }

        [DisplayName("Descri��o")]
        public string Description { get; set; }
        public bool Status { get; set; }

        [DisplayName("Data Abertura")]
        public DateTime DateInitial { get; set; } = DateTime.Now;

        [DisplayName("Data Conclus�o")]
        public DateTime DateEnd { get; set; }       
        public int ?User { get; set; }

        [DisplayName("Descri��o")]
        public string Comment { get; set; }
    }
}