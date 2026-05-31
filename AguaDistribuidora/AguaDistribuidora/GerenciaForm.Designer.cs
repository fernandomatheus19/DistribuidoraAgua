namespace AguaDistribuidora
{
    partial class GerenciaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCabecalho     = new System.Windows.Forms.Panel();
            this.lblTitulo        = new System.Windows.Forms.Label();
            this.btnAtualizar     = new System.Windows.Forms.Button();
            this.pnlCards         = new System.Windows.Forms.Panel();
            // Cards
            this.cardClientes     = new System.Windows.Forms.Panel();
            this.cardProdutos     = new System.Windows.Forms.Panel();
            this.cardEstoque      = new System.Windows.Forms.Panel();
            this.cardPedidos      = new System.Windows.Forms.Panel();
            this.cardReceita      = new System.Windows.Forms.Panel();
            this.cardAguardando   = new System.Windows.Forms.Panel();
            // Labels dos cards
            this.lblIcoClientes   = new System.Windows.Forms.Label();
            this.lblDescClientes  = new System.Windows.Forms.Label();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.lblIcoProdutos   = new System.Windows.Forms.Label();
            this.lblDescProdutos  = new System.Windows.Forms.Label();
            this.lblTotalProdutos = new System.Windows.Forms.Label();
            this.lblIcoEstoque    = new System.Windows.Forms.Label();
            this.lblDescEstoque   = new System.Windows.Forms.Label();
            this.lblValorEstoque  = new System.Windows.Forms.Label();
            this.lblIcoPedidos    = new System.Windows.Forms.Label();
            this.lblDescPedidos   = new System.Windows.Forms.Label();
            this.lblTotalPedidos  = new System.Windows.Forms.Label();
            this.lblIcoReceita    = new System.Windows.Forms.Label();
            this.lblDescReceita   = new System.Windows.Forms.Label();
            this.lblReceita       = new System.Windows.Forms.Label();
            this.lblIcoAguardando = new System.Windows.Forms.Label();
            this.lblDescAguardando= new System.Windows.Forms.Label();
            this.lblAguardando    = new System.Windows.Forms.Label();

            // ── Cabeçalho ────────────────────────────────────────
            this.pnlCabecalho.BackColor = System.Drawing.Color.FromArgb(20, 90, 160);
            this.pnlCabecalho.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Height    = 55;

            this.lblTitulo.Text      = "📊  Painel de Gerência";
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.AutoSize  = true;
            this.lblTitulo.Location  = new System.Drawing.Point(15, 14);

            this.btnAtualizar.Text      = "🔄 Atualizar";
            this.btnAtualizar.Location  = new System.Drawing.Point(920, 10);
            this.btnAtualizar.Size      = new System.Drawing.Size(120, 36);
            this.btnAtualizar.Font      = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(0, 140, 200);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Click    += new System.EventHandler(this.btnAtualizar_Click);

            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.btnAtualizar);

            // ── Painel dos cards ─────────────────────────────────
            this.pnlCards.Location  = new System.Drawing.Point(30, 75);
            this.pnlCards.Size      = new System.Drawing.Size(1040, 480);
            this.pnlCards.BackColor = System.Drawing.Color.Transparent;

            // Helper: cria um card
            void MakeCard(
                System.Windows.Forms.Panel card,
                System.Drawing.Color cor,
                System.Windows.Forms.Label ico, string icoTxt,
                System.Windows.Forms.Label desc, string descTxt,
                System.Windows.Forms.Label val,
                int x, int y)
            {
                card.Location    = new System.Drawing.Point(x, y);
                card.Size        = new System.Drawing.Size(300, 170);
                card.BackColor   = cor;
                card.BorderStyle = System.Windows.Forms.BorderStyle.None;

                ico.Text      = icoTxt;
                ico.Font      = new System.Drawing.Font("Segoe UI", 30);
                ico.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 100);
                ico.AutoSize  = true;
                ico.Location  = new System.Drawing.Point(220, 20);

                desc.Text      = descTxt;
                desc.Font      = new System.Drawing.Font("Segoe UI", 11);
                desc.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
                desc.AutoSize  = true;
                desc.Location  = new System.Drawing.Point(20, 20);

                val.Text      = "—";
                val.Font      = new System.Drawing.Font("Segoe UI", 30, System.Drawing.FontStyle.Bold);
                val.ForeColor = System.Drawing.Color.White;
                val.AutoSize  = true;
                val.Location  = new System.Drawing.Point(20, 90);

                card.Controls.Add(ico);
                card.Controls.Add(desc);
                card.Controls.Add(val);
                this.pnlCards.Controls.Add(card);
            }

            MakeCard(cardClientes,   System.Drawing.Color.FromArgb(20, 100, 180),
                     lblIcoClientes,   "👤", lblDescClientes,  "Clientes Ativos",    lblTotalClientes,  0,   0);
            MakeCard(cardProdutos,   System.Drawing.Color.FromArgb(0, 130, 100),
                     lblIcoProdutos,   "📦", lblDescProdutos,  "Produtos Cadastrados",lblTotalProdutos,  340, 0);
            MakeCard(cardEstoque,    System.Drawing.Color.FromArgb(130, 80, 0),
                     lblIcoEstoque,    "💰", lblDescEstoque,   "Valor em Estoque",    lblValorEstoque,   680, 0);
            MakeCard(cardPedidos,    System.Drawing.Color.FromArgb(100, 30, 140),
                     lblIcoPedidos,    "📋", lblDescPedidos,   "Total de Pedidos",    lblTotalPedidos,   0,   200);
            MakeCard(cardReceita,    System.Drawing.Color.FromArgb(0, 120, 60),
                     lblIcoReceita,    "💵", lblDescReceita,   "Receita Total",       lblReceita,        340, 200);
            MakeCard(cardAguardando, System.Drawing.Color.FromArgb(180, 100, 0),
                     lblIcoAguardando, "⏳", lblDescAguardando,"Pedidos Aguardando",  lblAguardando,     680, 200);

            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.pnlCards);

            this.Load += new System.EventHandler(this.GerenciaForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel   pnlCabecalho;
        private System.Windows.Forms.Label   lblTitulo;
        private System.Windows.Forms.Button  btnAtualizar;
        private System.Windows.Forms.Panel   pnlCards;
        private System.Windows.Forms.Panel   cardClientes, cardProdutos, cardEstoque;
        private System.Windows.Forms.Panel   cardPedidos, cardReceita, cardAguardando;
        private System.Windows.Forms.Label   lblIcoClientes, lblDescClientes, lblTotalClientes;
        private System.Windows.Forms.Label   lblIcoProdutos, lblDescProdutos, lblTotalProdutos;
        private System.Windows.Forms.Label   lblIcoEstoque,  lblDescEstoque,  lblValorEstoque;
        private System.Windows.Forms.Label   lblIcoPedidos,  lblDescPedidos,  lblTotalPedidos;
        private System.Windows.Forms.Label   lblIcoReceita,  lblDescReceita,  lblReceita;
        private System.Windows.Forms.Label   lblIcoAguardando, lblDescAguardando, lblAguardando;
    }
}
