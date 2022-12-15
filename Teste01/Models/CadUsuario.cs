using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste01.Models
{

    [Table("Usuarios")]
    public class CadUsuario
    {
        [Key]
        public int codigo { get; set; }

        public string nome { get; set; } 

        public int cpf { get; set; }

        public string endereco { get; set; }

        public int telefone { get; set; }
    }
}