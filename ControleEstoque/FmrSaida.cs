using ControleEstoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class FmrSaida : ControleEstoque.FrmBase
    {
        
        private int id = 0;
        private string produto = "";
        private decimal? quantidade = 0;
        private decimal? valorCusto = 0;
        private decimal? valorVenda = 0;
            public FmrSaida()
        {
            InitializeComponent();
            BloqueiaCampos();
            CarregarGrid();
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta c = new FrmConsulta();
            c.ShowDialog();
            if (c.idProduto != 0)
            {
                id = c.idProduto;
                produto = c.produto;
                valorCusto = c.valorCusto;
                valorVenda = c.valorVenda;
                quantidade = c.quantidade;
                
                txtId.Text = id.ToString();
                txtProduto.Text = produto;
                txtValorUnit.Text = valorCusto.ToString();
                
                LiberarCampos();
                txtId.Enabled = false;
                txtProduto.Enabled = false;
                txtValorUnit.Enabled = false;
                txtValorTotal.Enabled = false;
                txtQtd.Focus();
            }
        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {
            try
            {

                txtValorTotal.Text = (Decimal.Parse(txtValorUnit.Text) * Decimal.Parse(txtQtd.Text)).ToString();

            }catch (Exception ex)
            {

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Model set = new Model();
                DtoProduto p = new DtoProduto();
                DtoSaidaProduto sp = new DtoSaidaProduto();
                p.nome = produto;
                p.valorcusto = valorCusto;
                p.valorvenda = valorVenda;
                var restante = quantidade - Decimal.Parse(txtQtd.Text);
                p.quantidade = restante;

                p.id = id;
                set.EditProduto(p);
                
                sp.idproduto = id;
                sp.nome = produto;
                sp.qtdproduto = Decimal.Parse(txtQtd.Text);
                var data = new DateTime();
                data = DateTime.Today;
                sp.datasaida = data;

                set.SetSaida(sp);

                MessageBox.Show("Saída efetuada com sucesso!");
                
                BloqueiaCampos();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BloqueiaCampos()
        {
            txtId.Enabled = false;
            txtProduto.Enabled = false;
            txtQtd.Enabled = false;
            txtValorUnit.Enabled = false;
            txtValorTotal.Enabled = false;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            LiberarCampos();
            txtId.Text = "";
            txtProduto.Text = "";
            txtQtd.Text = "";
            txtValorUnit.Text = "";
            txtValorTotal.Text = "";
        }

        private void LiberarCampos()
        {
            txtId.Enabled = true;
            txtProduto.Enabled = true;
            txtQtd.Enabled = true;
            txtValorTotal.Enabled=true;
            txtValorUnit.Enabled = true;
        }

        private void CarregarGrid()
        {
            Model get = new Model();
            List<DtoSaidaProduto2> lista = get.ListSaidas();
            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Refresh();
        }

        private void h(object sender, EventArgs e)
        {

        }
    }
}
