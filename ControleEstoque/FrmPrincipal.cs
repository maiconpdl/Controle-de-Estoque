using ControleEstoque1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            bloqueiaTela();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            FrmProduto f = new FrmProduto();
            f.Show();
        }
        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario f = new FrmUsuario();
            f.Show();
        }

        private void BtnEntradas_Click(object sender, EventArgs e)
        {
            FrmEntrada f = new FrmEntrada();
            f.Show();
        }

        private void BtnSaidas_Click(object sender, EventArgs e)
        {
            FmrSaida s = new FmrSaida();
            s.Show();
        }

        private void bloqueiaTela()
        {
            BtnEntradas.Enabled = false;
            BtnProdutos.Enabled = false;
            BtnSaidas.Enabled = false;
            BtnUsuario.Enabled = false;
            lblNome.Visible = false;

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            Model get = new Model();
            DtoUsuario2 d = get.AutenticaUsuario(txtUsuario.Text, txtSenha.Text);
            if(d.senha == txtSenha.Text)
            {
                MessageBox.Show("Bem Vindo!" + "  " + txtUsuario.Text);
                BtnEntradas.Enabled = true;
                BtnProdutos.Enabled = true;
                BtnSaidas.Enabled = true;
                BtnUsuario.Enabled = true;
                txtSenha.Visible = false;
                txtUsuario.Visible = false;
                btnEntrar.Visible = false;
                lblSenha.Visible = false;
                lblUsuario.Visible = false;
                label4.Visible = false;
                lblNome.Text = d.nome;
                lblNome.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                txtUsuario.Focus();
            }
        }
    }
}
