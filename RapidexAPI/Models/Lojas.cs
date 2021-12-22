using System.ComponentModel.DataAnnotations;

namespace RapidexAPI.Models
{
    public class Lojas
    {   
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Cnpj { get; set; }
        public string NickName { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Complement { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State{ get; set; }
        public string Phone { get; set; }
        [Required]
        public bool Active{ get; set; }


    }
}
