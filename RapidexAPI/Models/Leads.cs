using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapidexAPI.Models
{
    public class Leads
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [ForeignKey("IdLoja")]
        public Lojas Lojas { get; set; }
        
        [Required(ErrorMessage ="O campo Nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage ="O campo Cpf é obrigatório")]
        public int Cpf { get; set; }
    }
}
