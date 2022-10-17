using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace EscuelaComputacion.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Schedule { get; set; }
        public string ProfessorName { get; set; }

    }
}
