using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapidexAPI.Models
{
    public class Veiculos
    {   
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo Nome do veículo é obrigatório")]
        public string Nome { get; set; }
        [ForeignKey("IdLoja")]
        public Lojas Lojas { get; set; }
    }
}
