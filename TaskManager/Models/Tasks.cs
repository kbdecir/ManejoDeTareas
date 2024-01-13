using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class Tasks
    {
        [Key]
        public int ID { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaDeCreacion { get; set; }

        public string Estado { get; set; }

        public int Prioridad { get; set; }
    }
}
