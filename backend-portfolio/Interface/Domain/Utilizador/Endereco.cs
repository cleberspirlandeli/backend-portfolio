using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Interface.Domain.Utilizador
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Key]
        [Column("IdUsuario")]
        public int IdUsuario { get; set; }

        [Required]
        [Column("Cep")]
        [StringLength(10)]
        public string Cep { get; set; }

        [Required]
        [Column("Logradouro")]
        [StringLength(150)]
        public string Logradouro { get; set; }

        [Required]
        [Column("Bairro")]
        [StringLength(100)]
        public string Bairro { get; set; }

        [Required]
        [Column("Numero")]
        [StringLength(30)]
        public string Numero { get; set; }

        [Required]
        [Column("Complemento")]
        [StringLength(100)]
        public string Complemento { get; set; }
    }
}
