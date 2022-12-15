using System.Data.Entity;

namespace Teste01.Models
{
    public class UsuarioContexto : DbContext
    {
        public DbSet<CadUsuario> usuario { get; set; }
    }
}