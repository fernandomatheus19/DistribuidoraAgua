namespace AguaDistribuidora
{
    partial class ClientesForm
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
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblNome       = new System.Windows.Forms.Label();
            this.txtNome       = new System.Windows.Forms.TextBox();
            this.lblTelefone   = new System.Windows.Forms.Label();
            this.txtTelefone   = new System.Windows.Forms.TextBox();
            this.lblEndereco   = new System.Windows.Forms.Label();
            this.txtEndereco   = new System.Windows.Forms.TextBox();
            this.lblBairro     = new System.Windows.Forms.Label();
            this.txtBairro     = new System.Windows.Forms.TextBox();
            this.lblCidade     = new System.Windows.Forms.Label();
            this.txtCidade     = new System.Windows.Forms.TextBox();
            this.btnSalvar     = new System.Windows.Forms.Button();
            this.btnExcluir    = new System.Windows.Forms.Button();
            this.btnLimpar     = new System.Windows.Forms.Button();
            this.dgvClientes   = new System.Windows.Forms.DataGridView();

            // Cabeçalho
            this.pnlCabecalho.BackColor = System.Drawing.Color.FromArgb(20, 90, 160);
            this.pnlCabecalho.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Height    = 50;

            this.lblTitulo.Text      = "👤  Cadastro de Clientes";
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.AutoSize  = true;
            this.lblTitulo.Location  = new System.Drawing.Point(15, 12);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);

            // Formulário
            this.pnlFormulario.BackColor  = System.Drawing.Color.White;
            this.pnlFormulario.Location   = new System.Drawing.Point(10, 60);
            this.pnlFormulario.Size       = new System.Drawing.Size(1060, 120);
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            void AddLbl(System.Windows.Forms.Label l, string t, int x, int y)
            {
                l.Text = t; l.AutoSize = true; l.Location = new System.Drawing.Point(x, y);
                l.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold);
                l.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
                this.pnlFormulario.Controls.Add(l);
            }
            void AddTxt(System.Windows.Forms.TextBox t, int x, int y, int w)
            {
                t.Location = new System.Drawing.Point(x, y); t.Size = new System.Drawing.Size(w, 28);
                t.Font = new System.Drawing.Font("Segoe UI", 10);
                t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.pnlFormulario.Controls.Add(t);
            }

            AddLbl(lblNome,     "Nome",     10,  10); AddTxt(txtNome,     10,  30, 250);
            AddLbl(lblTelefone, "Telefone", 270, 10); AddTxt(txtTelefone, 270, 30, 140);
            AddLbl(lblEndereco, "Endereço", 420, 10); AddTxt(txtEndereco, 420, 30, 250);
            AddLbl(lblBairro,   "Bairro",   680, 10); AddTxt(txtBairro,   680, 30, 150);
            AddLbl(lblCidade,   "Cidade",   840, 10); AddTxt(txtCidade,   840, 30, 140);

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

            this.pnlFormulario.Controls.Add(this.btnSalvar);
            this.pnlFormulario.Controls.Add(this.btnExcluir);
            this.pnlFormulario.Controls.Add(this.btnLimpar);

            // DataGridView
            this.dgvClientes.Location            = new System.Drawing.Point(10, 190);
            this.dgvClientes.Size                = new System.Drawing.Size(1060, 370);
            this.dgvClientes.BackgroundColor     = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.RowHeadersVisible   = false;
            this.dgvClientes.AllowUserToAddRows  = false;
            this.dgvClientes.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.ReadOnly            = true;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.Font                = new System.Drawing.Font("Segoe UI", 10);
            this.dgvClientes.RowTemplate.Height  = 32;
            this.dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 90, 160);
            this.dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.dgvClientes.EnableHeadersVisualStyles               = false;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);

            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.dgvClientes);

            this.Load += new System.EventHandler(this.ClientesForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel        pnlCabecalho;
        private System.Windows.Forms.Label        lblTitulo;
        private System.Windows.Forms.Panel        pnlFormulario;
        private System.Windows.Forms.Label        lblNome, lblTelefone, lblEndereco, lblBairro, lblCidade;
        private System.Windows.Forms.TextBox      txtNome, txtTelefone, txtEndereco, txtBairro, txtCidade;
        private System.Windows.Forms.Button       btnSalvar, btnExcluir, btnLimpar;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}
