namespace AguaDistribuidora
{
    partial class PrincipalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip      = new System.Windows.Forms.MenuStrip();
            this.menuArquivo    = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair       = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidos    = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstoque    = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes   = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGerencia   = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip    = new System.Windows.Forms.StatusStrip();
            this.lblUsuario     = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus      = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData        = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlConteudo    = new System.Windows.Forms.Panel();

            // ── Formulário ──────────────────────────────────────
            this.Text            = "💧 AguaFácil – Distribuidora de Água";
            this.Size            = new System.Drawing.Size(1100, 680);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor       = System.Drawing.Color.FromArgb(240, 245, 255);
            this.Load           += new System.EventHandler(this.PrincipalForm_Load);

            // ── MenuStrip ────────────────────────────────────────
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(20, 90, 160);
            this.menuStrip.ForeColor = System.Drawing.Color.White;
            this.menuStrip.Font      = new System.Drawing.Font("Segoe UI", 10);
            this.menuStrip.Padding   = new System.Windows.Forms.Padding(6, 4, 0, 4);

            this.menuArquivo.Text = "Arquivo";
            this.menuArquivo.ForeColor = System.Drawing.Color.White;
            this.menuSair.Text = "Sair";
            this.menuSair.ForeColor = System.Drawing.Color.White;
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            this.menuArquivo.DropDownItems.Add(this.menuSair);

            this.menuPedidos.Text      = "📋  Pedidos";
            this.menuPedidos.ForeColor = System.Drawing.Color.White;
            this.menuPedidos.Click    += new System.EventHandler(this.menuPedidos_Click);

            this.menuEstoque.Text      = "📦  Estoque";
            this.menuEstoque.ForeColor = System.Drawing.Color.White;
            this.menuEstoque.Click    += new System.EventHandler(this.menuEstoque_Click);

            this.menuClientes.Text      = "👤  Clientes";
            this.menuClientes.ForeColor = System.Drawing.Color.White;
            this.menuClientes.Click    += new System.EventHandler(this.menuClientes_Click);

            this.menuGerencia.Text      = "📊  Gerência";
            this.menuGerencia.ForeColor = System.Drawing.Color.White;
            this.menuGerencia.Click    += new System.EventHandler(this.menuGerencia_Click);

            this.menuStrip.Items.Add(this.menuArquivo);
            this.menuStrip.Items.Add(this.menuPedidos);
            this.menuStrip.Items.Add(this.menuEstoque);
            this.menuStrip.Items.Add(this.menuClientes);
            this.menuStrip.Items.Add(this.menuGerencia);

            // ── StatusStrip ──────────────────────────────────────
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(20, 90, 160);

            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Font      = new System.Drawing.Font("Segoe UI", 9);

            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(100, 200, 100);
            this.lblStatus.Font      = new System.Drawing.Font("Segoe UI", 9);
            this.lblStatus.Spring    = true;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Font      = new System.Drawing.Font("Segoe UI", 9);

            this.statusStrip.Items.Add(this.lblUsuario);
            this.statusStrip.Items.Add(this.lblStatus);
            this.statusStrip.Items.Add(this.lblData);

            // ── Painel conteúdo ──────────────────────────────────
            this.pnlConteudo.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);

            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip              menuStrip;
        private System.Windows.Forms.ToolStripMenuItem      menuArquivo;
        private System.Windows.Forms.ToolStripMenuItem      menuSair;
        private System.Windows.Forms.ToolStripMenuItem      menuPedidos;
        private System.Windows.Forms.ToolStripMenuItem      menuEstoque;
        private System.Windows.Forms.ToolStripMenuItem      menuClientes;
        private System.Windows.Forms.ToolStripMenuItem      menuGerencia;
        private System.Windows.Forms.StatusStrip             statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel   lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel   lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel   lblData;
        private System.Windows.Forms.Panel                  pnlConteudo;
    }
}
