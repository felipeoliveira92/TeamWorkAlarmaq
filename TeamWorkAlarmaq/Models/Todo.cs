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

        [DisplayName("Descrição")]
        public string Description { get; set; }
        public string Status { get; set; } = "Aberto";

        [DisplayName("Data Abertura")]
        public DateTime DateInitial { get; set; } = DateTime.Now;

        [DisplayName("Data Conclusão")]
        public DateTime DateEnd { get; set; }       
        public int ?User { get; set; }
    }
}