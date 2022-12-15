using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste01.Models.EF
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Codigo { get; set; }

        [Required]
        [MaxLength(32)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(11)]
        public string CPF { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string Endereco { get; set; }

        [MaxLength(20)]
        public int Telefone { get; set; }

    }
}