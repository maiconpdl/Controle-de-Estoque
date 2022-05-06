using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
    [Table("saidaproduto", Schema = "public")]
    public class DtoSaidaProduto
    {
        [Key]
        public int id { get; set; }
        public int idproduto { get; set; }
        public string nome { get; set; }
        public decimal qtdproduto { get; set; }        
        public DateTime? datasaida { get; set; }
    }
}
