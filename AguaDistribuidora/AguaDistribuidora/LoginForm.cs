using System;
using System.Drawing;
using System.Windows.Forms;

namespace AguaDistribuidora
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            // Credenciais fixas (simples/básico)
            if (usuario == "admin" && senha == "1234")
            {
                var principal = new PrincipalForm();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Acesso Negado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
