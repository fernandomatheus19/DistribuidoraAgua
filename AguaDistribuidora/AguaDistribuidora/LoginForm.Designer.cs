namespace AguaDistribuidora
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlTopo = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlCard = new Panel();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btnLogin = new Button();
            lblRodape = new Label();
            pnlTopo.SuspendLayout();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.Transparent;
            pnlTopo.Controls.Add(lblTitulo);
            pnlTopo.Controls.Add(lblSubtitulo);
            pnlTopo.Location = new Point(0, 30);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(420, 110);
            pnlTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(110, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(273, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "💧 AguaFácil";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.FromArgb(180, 220, 255);
            lblSubtitulo.Location = new Point(118, 62);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(197, 25);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Distribuidora de Água";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(lblUsuario);
            pnlCard.Controls.Add(txtUsuario);
            pnlCard.Controls.Add(lblSenha);
            pnlCard.Controls.Add(txtSenha);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Location = new Point(30, 160);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(360, 290);
            pnlCard.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(80, 80, 80);
            lblUsuario.Location = new Point(30, 30);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(30, 52);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 32);
            txtUsuario.TabIndex = 1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSenha.ForeColor = Color.FromArgb(80, 80, 80);
            lblSenha.Location = new Point(30, 110);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(51, 20);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.Location = new Point(30, 132);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.Size = new Size(300, 32);
            txtSenha.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(20, 90, 160);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ENTRAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblRodape
            // 
            lblRodape.AutoSize = true;
            lblRodape.Font = new Font("Segoe UI", 8F);
            lblRodape.ForeColor = Color.FromArgb(160, 200, 240);
            lblRodape.Location = new Point(100, 470);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(196, 19);
            lblRodape.TabIndex = 2;
            lblRodape.Text = "Usuário: admin  |  Senha: 1234";
            // 
            // LoginForm
            // 
            BackColor = Color.FromArgb(20, 90, 160);
            ClientSize = new Size(402, 473);
            Controls.Add(pnlTopo);
            Controls.Add(pnlCard);
            Controls.Add(lblRodape);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distribuidora de Água – Login";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel   pnlTopo;
        private System.Windows.Forms.Label   lblTitulo;
        private System.Windows.Forms.Label   lblSubtitulo;
        private System.Windows.Forms.Panel   pnlCard;
        private System.Windows.Forms.Label   lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label   lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button  btnLogin;
        private System.Windows.Forms.Label   lblRodape;
    }
}
