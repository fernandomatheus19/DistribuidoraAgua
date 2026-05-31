namespace AguaDistribuidora
{
    partial class PedidosForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCabecalho   = new System.Windows.Forms.Panel();
            this.lblTitulo      = new System.Windows.Forms.Label();
            this.pnlFormulario  = new System.Windows.Forms.Panel();
            this.lblCliente     = new System.Windows.Forms.Label();
            this.txtCliente     = new System.Windows.Forms.TextBox();
            this.lblTelefone    = new System.Windows.Forms.Label();
            this.txtTelefone    = new System.Windows.Forms.TextBox();
            this.lblProduto     = new System.Windows.Forms.Label();
            this.cmbProduto     = new System.Windows.Forms.ComboBox();
            this.lblQuantidade  = new System.Windows.Forms.Label();
            this.txtQuantidade  = new System.Windows.Forms.TextBox();
            this.lblValor       = new System.Windows.Forms.Label();
            this.txtValor       = new System.Windows.Forms.TextBox();
            this.lblEndereco    = new System.Windows.Forms.Label();
            this.txtEndereco    = new System.Windows.Forms.TextBox();
            this.lblBairro      = new System.Windows.Forms.Label();
            this.txtBairro      = new System.Windows.Forms.TextBox();
            this.lblPedido      = new System.Windows.Forms.Label();
            this.dtpPedido      = new System.Windows.Forms.DateTimePicker();
            this.lblEntrega     = new System.Windows.Forms.Label();
            this.dtpEntrega     = new System.Windows.Forms.DateTimePicker();
            this.lblStatus      = new System.Windows.Forms.Label();
            this.cmbStatus      = new System.Windows.Forms.ComboBox();
            this.lblObservacao  = new System.Windows.Forms.Label();
            this.txtObservacao  = new System.Windows.Forms.TextBox();
            this.btnSalvar      = new System.Windows.Forms.Button();
            this.btnExcluir     = new System.Windows.Forms.Button();
            this.btnLimpar      = new System.Windows.Forms.Button();
            this.dgvPedidos     = new System.Windows.Forms.DataGridView();

            // ── Cabeçalho ────────────────────────────────────────
            this.pnlCabecalho.BackColor = System.Drawing.Color.FromArgb(20, 90, 160);
            this.pnlCabecalho.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Height    = 50;

            this.lblTitulo.Text      = "📋  Gerenciamento de Pedidos";
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.AutoSize  = true;
            this.lblTitulo.Location  = new System.Drawing.Point(15, 12);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);

            // ── Painel do formulário ─────────────────────────────
            this.pnlFormulario.BackColor  = System.Drawing.Color.White;
            this.pnlFormulario.Location   = new System.Drawing.Point(10, 60);
            this.pnlFormulario.Size       = new System.Drawing.Size(1060, 220);
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Helpers locais
            int lh = 22; // label height
            int th = 28; // textbox height

            void AddLabel(System.Windows.Forms.Label l, string text, int x, int y)
            {
                l.Text = text; l.AutoSize = true; l.Location = new System.Drawing.Point(x, y);
                l.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold);
                l.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
                this.pnlFormulario.Controls.Add(l);
            }
            void AddText(System.Windows.Forms.TextBox t, int x, int y, int w)
            {
                t.Location = new System.Drawing.Point(x, y); t.Size = new System.Drawing.Size(w, th);
                t.Font = new System.Drawing.Font("Segoe UI", 10);
                t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.pnlFormulario.Controls.Add(t);
            }

            AddLabel(lblCliente, "Cliente", 10, 10);
            AddText(txtCliente, 10, 10 + lh, 200);

            AddLabel(lblTelefone, "Telefone", 220, 10);
            AddText(txtTelefone, 220, 10 + lh, 140);

            AddLabel(lblProduto, "Produto", 370, 10);
            this.cmbProduto.Location = new System.Drawing.Point(370, 10 + lh);
            this.cmbProduto.Size     = new System.Drawing.Size(180, th);
            this.cmbProduto.Font     = new System.Drawing.Font("Segoe UI", 10);
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            this.pnlFormulario.Controls.Add(this.cmbProduto);
            AddLabel(lblProduto, "Produto", 370, 10);

            AddLabel(lblQuantidade, "Quantidade", 560, 10);
            AddText(txtQuantidade, 560, 10 + lh, 80);
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);

            AddLabel(lblValor, "Valor R$ (auto)", 650, 10);
            AddText(txtValor, 650, 10 + lh, 100);
            this.txtValor.ReadOnly   = true;
            this.txtValor.BackColor  = System.Drawing.Color.FromArgb(240, 248, 240);

            AddLabel(lblStatus, "Status", 760, 10);
            this.cmbStatus.Location      = new System.Drawing.Point(760, 10 + lh);
            this.cmbStatus.Size          = new System.Drawing.Size(130, th);
            this.cmbStatus.Font          = new System.Drawing.Font("Segoe UI", 10);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pnlFormulario.Controls.Add(this.cmbStatus);
            AddLabel(lblStatus, "Status", 760, 10);

            // Row 2
            AddLabel(lblEndereco, "Endereço", 10, 80);
            AddText(txtEndereco, 10, 80 + lh, 250);

            AddLabel(lblBairro, "Bairro", 270, 80);
            AddText(txtBairro, 270, 80 + lh, 150);

            AddLabel(lblPedido, "Data Pedido", 430, 80);
            this.dtpPedido.Location = new System.Drawing.Point(430, 80 + lh);
            this.dtpPedido.Size     = new System.Drawing.Size(140, th);
            this.dtpPedido.Font     = new System.Drawing.Font("Segoe UI", 10);
            this.dtpPedido.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pnlFormulario.Controls.Add(this.dtpPedido);

            AddLabel(lblEntrega, "Data Entrega", 580, 80);
            this.dtpEntrega.Location = new System.Drawing.Point(580, 80 + lh);
            this.dtpEntrega.Size     = new System.Drawing.Size(140, th);
            this.dtpEntrega.Font     = new System.Drawing.Font("Segoe UI", 10);
            this.dtpEntrega.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pnlFormulario.Controls.Add(this.dtpEntrega);

            AddLabel(lblObservacao, "Observação", 730, 80);
            AddText(txtObservacao, 730, 80 + lh, 300);

            // Botões
            this.btnSalvar.Text      = "💾 Salvar";
            this.btnSalvar.Location  = new System.Drawing.Point(10, 160);
            this.btnSalvar.Size      = new System.Drawing.Size(110, 38);
            this.btnSalvar.Font      = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(20, 90, 160);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Click    += new System.EventHandler(this.btnSalvar_Click);

            this.btnExcluir.Text      = "🗑 Excluir";
            this.btnExcluir.Location  = new System.Drawing.Point(130, 160);
            this.btnExcluir.Size      = new System.Drawing.Size(110, 38);
            this.btnExcluir.Font      = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Click    += new System.EventHandler(this.btnExcluir_Click);

            this.btnLimpar.Text      = "🔄 Limpar";
            this.btnLimpar.Location  = new System.Drawing.Point(250, 160);
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

            // ── DataGridView ─────────────────────────────────────
            this.dgvPedidos.Location                  = new System.Drawing.Point(10, 290);
            this.dgvPedidos.Size                      = new System.Drawing.Size(1060, 300);
            this.dgvPedidos.BackgroundColor           = System.Drawing.Color.White;
            this.dgvPedidos.BorderStyle               = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.RowHeadersVisible         = false;
            this.dgvPedidos.AllowUserToAddRows        = false;
            this.dgvPedidos.SelectionMode             = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.ReadOnly                  = true;
            this.dgvPedidos.AutoSizeColumnsMode       = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.Font                      = new System.Drawing.Font("Segoe UI", 9);
            this.dgvPedidos.ColumnHeadersDefaultCellStyle.BackColor  = System.Drawing.Color.FromArgb(20, 90, 160);
            this.dgvPedidos.ColumnHeadersDefaultCellStyle.ForeColor  = System.Drawing.Color.White;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle.Font       = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.dgvPedidos.EnableHeadersVisualStyles                 = false;
            this.dgvPedidos.CellClick                                += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellClick);

            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.dgvPedidos);

            this.Load += new System.EventHandler(this.PedidosForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel            pnlCabecalho;
        private System.Windows.Forms.Label            lblTitulo;
        private System.Windows.Forms.Panel            pnlFormulario;
        private System.Windows.Forms.Label            lblCliente, lblTelefone, lblProduto;
        private System.Windows.Forms.Label            lblQuantidade, lblValor, lblStatus;
        private System.Windows.Forms.Label            lblEndereco, lblBairro;
        private System.Windows.Forms.Label            lblPedido, lblEntrega, lblObservacao;
        private System.Windows.Forms.TextBox          txtCliente, txtTelefone, txtQuantidade;
        private System.Windows.Forms.TextBox          txtValor, txtEndereco, txtBairro, txtObservacao;
        private System.Windows.Forms.ComboBox         cmbProduto, cmbStatus;
        private System.Windows.Forms.DateTimePicker   dtpPedido, dtpEntrega;
        private System.Windows.Forms.Button           btnSalvar, btnExcluir, btnLimpar;
        private System.Windows.Forms.DataGridView     dgvPedidos;
    }
}
