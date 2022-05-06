using System;


namespace ControleEstoque1
{
    public class DtoSaidaProduto2
    {
        public int id { get; set; }
        public int idproduto { get; set; }
        public string nome { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime? datasaida { get; set; }
    }
}
