namespace AguaDistribuidora
{
    partial class EstoqueForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCabecalho  = new System.Windows.Forms.Panel();
            this.lblTitulo     = new System.Windows.Forms.Label();
            this.lblLegenda    = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblNome       = new System.Windows.Forms.Label();
            this.txtNome       = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblPreco      = new System.Windows.Forms.Label();
            this.txtPreco      = new System.Windows.Forms.TextBox();
            this.btnSalvar     = new System.Windows.Forms.Button();
            this.btnExcluir    = new System.Windows.Forms.Button();
            this.btnLimpar     = new System.Windows.Forms.Button();
            this.dgvProdutos   = new System.Windows.Forms.DataGridView();

            // Cabeçalho
            this.pnlCabecalho.BackColor = System.Drawing.Color.FromArgb(20, 90, 160);
            this.pnlCabecalho.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Height    = 50;

            this.lblTitulo.Text      = "📦  Controle de Estoque";
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.AutoSize  = true;
            this.lblTitulo.Location  = new System.Drawing.Point(15, 12);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);

            // Painel formulário
            this.pnlFormulario.BackColor  = System.Drawing.Color.White;
            this.pnlFormulario.Location   = new System.Drawing.Point(10, 60);
            this.pnlFormulario.Size       = new System.Drawing.Size(1060, 120);
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblNome.Text = "Produto"; this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(10, 10);
            this.txtNome.Location = new System.Drawing.Point(10, 30);
            this.txtNome.Size     = new System.Drawing.Size(280, 28);
            this.txtNome.Font     = new System.Drawing.Font("Segoe UI", 10);
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblQuantidade.Text = "Quantidade"; this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold);
            this.lblQuantidade.Location = new System.Drawing.Point(300, 10);
            this.txtQuantidade.Location = new System.Drawing.Point(300, 30);
            this.txtQuantidade.Size     = new System.Drawing.Size(120, 28);
            this.txtQuantidade.Font     = new System.Drawing.Font("Segoe UI", 10);
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblPreco.Text = "Preço Unitário (R$)"; this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold);
            this.lblPreco.Location = new System.Drawing.Point(430, 10);
            this.txtPreco.Location = new System.Drawing.Point(430, 30);
            this.txtPreco.Size     = new System.Drawing.Size(140, 28);
            this.txtPreco.Font     = new System.Drawing.Font("Segoe UI", 10);
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Botões
            this.btnSalvar.Text      = "💾 Salvar";
            this.btnSalvar.Location  = new System.Drawing.Point(10, 68);
            this.btnSalvar.Size      = new System.Drawing.Size(110, 38);
            this.btnSalvar.Font      = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(20, 90, 160);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Click    += new System.EventHandler(this.btnSalvar_Click);

            this.btnExcluir.Text      = "🗑 Excluir";
            this.btnExcluir.Location  = new System.Drawing.Point(130, 68);
            this.btnExcluir.Size      = new System.Drawing.Size(110, 38);
            this.btnExcluir.Font      = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Click    += new System.EventHandler(this.btnExcluir_Click);

            this.btnLimpar.Text      = "🔄 Limpar";
            this.btnLimpar.Location  = new System.Drawing.Point(250, 68);
            this.btnLimpar.Size      = new System.Drawing.Size(110, 38);
            this.btnLimpar.Font      = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Click    += new System.EventHandler(this.btnLimpar_Click);

            this.pnlFormulario.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblNome, txtNome, lblQuantidade, txtQuantidade, lblPreco, txtPreco,
                btnSalvar, btnExcluir, btnLimpar
            });

            // Legenda cores
            this.lblLegenda.Text      = "🟢 Estoque normal   🟡 Estoque baixo (≤15)   🔴 Crítico (≤5)";
            this.lblLegenda.Location  = new System.Drawing.Point(10, 190);
            this.lblLegenda.AutoSize  = true;
            this.lblLegenda.Font      = new System.Drawing.Font("Segoe UI", 9);
            this.lblLegenda.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            // DataGridView
            this.dgvProdutos.Location                  = new System.Drawing.Point(10, 215);
            this.dgvProdutos.Size                      = new System.Drawing.Size(1060, 340);
            this.dgvProdutos.BackgroundColor           = System.Drawing.Color.White;
            this.dgvProdutos.BorderStyle               = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.RowHeadersVisible         = false;
            this.dgvProdutos.AllowUserToAddRows        = false;
            this.dgvProdutos.SelectionMode             = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.ReadOnly                  = true;
            this.dgvProdutos.AutoSizeColumnsMode       = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.Font                      = new System.Drawing.Font("Segoe UI", 10);
            this.dgvProdutos.RowTemplate.Height        = 32;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.BackColor  = System.Drawing.Color.FromArgb(20, 90, 160);
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.ForeColor  = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.Font       = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.dgvProdutos.EnableHeadersVisualStyles                 = false;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);

            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.dgvProdutos);

            this.Load += new System.EventHandler(this.EstoqueForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel        pnlCabecalho;
        private System.Windows.Forms.Label        lblTitulo, lblLegenda;
        private System.Windows.Forms.Panel        pnlFormulario;
        private System.Windows.Forms.Label        lblNome, lblQuantidade, lblPreco;
        private System.Windows.Forms.TextBox      txtNome, txtQuantidade, txtPreco;
        private System.Windows.Forms.Button       btnSalvar, btnExcluir, btnLimpar;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}
