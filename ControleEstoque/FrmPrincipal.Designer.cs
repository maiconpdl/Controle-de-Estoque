
namespace ControleEstoque
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelTopo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.BtnSaidas = new System.Windows.Forms.Button();
            this.BtnEntradas = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.panelInteiro = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.panelTopo.SuspendLayout();
            this.panelMenuLateral.SuspendLayout();
            this.panelInteiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.Orange;
            this.panelTopo.Controls.Add(this.lblNome);
            this.panelTopo.Controls.Add(this.label1);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(800, 61);
            this.panelTopo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle de Estoque";
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMenuLateral.Controls.Add(this.BtnUsuario);
            this.panelMenuLateral.Controls.Add(this.BtnSaidas);
            this.panelMenuLateral.Controls.Add(this.BtnEntradas);
            this.panelMenuLateral.Controls.Add(this.BtnProdutos);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 61);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(174, 389);
            this.panelMenuLateral.TabIndex = 1;
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.FlatAppearance.BorderSize = 0;
            this.BtnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUsuario.Image = global::ControleEstoque1.Properties.Resources.icons8_grupo_de_usuário_homem_homem_50;
            this.BtnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuario.Location = new System.Drawing.Point(12, 216);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(147, 55);
            this.BtnUsuario.TabIndex = 0;
            this.BtnUsuario.Text = "Usuários";
            this.BtnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // BtnSaidas
            // 
            this.BtnSaidas.FlatAppearance.BorderSize = 0;
            this.BtnSaidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnSaidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.BtnSaidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaidas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSaidas.Image = global::ControleEstoque1.Properties.Resources.icons8_performance_de_vendas_50;
            this.BtnSaidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaidas.Location = new System.Drawing.Point(12, 141);
            this.BtnSaidas.Name = "BtnSaidas";
            this.BtnSaidas.Size = new System.Drawing.Size(147, 55);
            this.BtnSaidas.TabIndex = 0;
            this.BtnSaidas.Text = "Saídas";
            this.BtnSaidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSaidas.UseVisualStyleBackColor = true;
            this.BtnSaidas.Click += new System.EventHandler(this.BtnSaidas_Click);
            // 
            // BtnEntradas
            // 
            this.BtnEntradas.FlatAppearance.BorderSize = 0;
            this.BtnEntradas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.BtnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntradas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEntradas.Image = global::ControleEstoque1.Properties.Resources.icons8_caminhão_64;
            this.BtnEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntradas.Location = new System.Drawing.Point(12, 80);
            this.BtnEntradas.Name = "BtnEntradas";
            this.BtnEntradas.Size = new System.Drawing.Size(147, 55);
            this.BtnEntradas.TabIndex = 0;
            this.BtnEntradas.Text = "Entradas";
            this.BtnEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEntradas.UseVisualStyleBackColor = true;
            this.BtnEntradas.Click += new System.EventHandler(this.BtnEntradas_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.FlatAppearance.BorderSize = 0;
            this.BtnProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProdutos.Image = global::ControleEstoque1.Properties.Resources.icons8_produto_50;
            this.BtnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdutos.Location = new System.Drawing.Point(12, 19);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(147, 55);
            this.BtnProdutos.TabIndex = 0;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // panelInteiro
            // 
            this.panelInteiro.Controls.Add(this.btnEntrar);
            this.panelInteiro.Controls.Add(this.txtSenha);
            this.panelInteiro.Controls.Add(this.txtUsuario);
            this.panelInteiro.Controls.Add(this.lblSenha);
            this.panelInteiro.Controls.Add(this.label4);
            this.panelInteiro.Controls.Add(this.lblUsuario);
            this.panelInteiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInteiro.Location = new System.Drawing.Point(174, 61);
            this.panelInteiro.Name = "panelInteiro";
            this.panelInteiro.Size = new System.Drawing.Size(626, 389);
            this.panelInteiro.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(201, 179);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(201, 219);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(250, 176);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(115, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(250, 219);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(115, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login";
            this.label4.UseMnemonic = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(260, 271);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(606, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "label2";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInteiro);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.panelTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.panelMenuLateral.ResumeLayout(false);
            this.panelInteiro.ResumeLayout(false);
            this.panelInteiro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelInteiro;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button BtnSaidas;
        private System.Windows.Forms.Button BtnEntradas;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNome;
    }
}

