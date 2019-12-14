using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Interface.Domain.Utilizador
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Nome")]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required]
        [Column("Email")]
        [StringLength(150)]
        public string Email { get; set; }

        [Required]
        [Column("CpfCnpj")]
        [StringLength(30)]
        public string CpfCnpj { get; set; }

        [Required]
        [Column("Senha")]
        [StringLength(50)]
        public string Senha { get; set; }

        [Required]
        [Column("Ativo")]
        public bool Ativo { get; set; }

        [Required]
        [Column("Bloqueado")]
        public bool Bloqueado { get; set; }

        [Required]
        [Column("TipoUsuario")]
        public Enum TipoUsuario { get; set; }

        [Required]
        [Column("CriadoEm")]
        public DateTime CriadoEm { get; set; }

        [Required]
        [Column("AlteradoEm")]
        public DateTime AlteradoEm { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}
