using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class FrmConsulta : Form
    {
        public int idProduto = 0;
        public string produto = "";
        public decimal valorCusto = 0;
        public decimal valorVenda = 0;
        public decimal quantidade = 0;
        public FrmConsulta()
        {
            InitializeComponent();
            carregaGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Model m = new Model();
            List<DtoProduto2> list = m.ListProdutosNome(textBox1.Text);
            dataGridView1.DataSource = list;

        }

        private void carregaGrid()
        {
            Model m = new Model();
            List<DtoProduto2> list = m.ListProdutosNome(textBox1.Text);
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                idProduto = (Int32)dataGridView1.CurrentRow.Cells[0].Value;
                produto = (String)dataGridView1.CurrentRow.Cells[1].Value;
                valorCusto = (Decimal)dataGridView1.CurrentRow.Cells[2].Value;
                valorVenda = (Decimal)dataGridView1.CurrentRow.Cells [3].Value;
                quantidade = (Decimal)dataGridView1.CurrentRow.Cells[4].Value;
                Close();
            }
        }
    }
}
