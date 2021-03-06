using ControleEstoque1;
using System.Data.Entity;

namespace ControleEstoque
{
    public class Context: DbContext
    {
        public Context() : base("BD")
        {
        }
        public DbSet<DtoUsuario> usuario { get; set; }
        public DbSet<DtoProduto> produto { get; set; }
        public DbSet<DtoEntradaProduto> entradaproduto { get; set; }
        public DbSet<DtoSaidaProduto> saidaproduto { get; set; }
    }
}
