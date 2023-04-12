using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DtisCrudMVC.Models
{
    [Table("Contato")]
    public class Contato
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Cpf")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
    }
}
