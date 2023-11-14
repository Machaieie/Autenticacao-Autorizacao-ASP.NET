using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercicio8.Models
{
    [Table(name:"Usuario")]
    public class Usuario
    {
        [Key]
        [Column("Id")]
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Column("Usuario")]
        [Display(Name = "Usuario")]
        public string? Username { get; set; }
        [Column("Password")]
        [Display(Name = "Senha")]
        public string? Password { get; set; }
        [Column("Role")]
        [Display(Name = "Role")]
        public string? Role { get; set; }
    }
}
