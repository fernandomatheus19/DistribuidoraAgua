using System;
using System.Windows.Forms;

namespace AguaDistribuidora
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário: Admin";
            lblStatus.Text  = "Sistema Online";
            lblData.Text    = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void AbrirForm(Form form)
        {
            pnlConteudo.Controls.Clear();
            form.TopLevel         = false;
            form.FormBorderStyle  = FormBorderStyle.None;
            form.Dock             = DockStyle.Fill;
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void menuPedidos_Click(object sender, EventArgs e)
            => AbrirForm(new PedidosForm());

        private void menuEstoque_Click(object sender, EventArgs e)
            => AbrirForm(new EstoqueForm());

        private void menuClientes_Click(object sender, EventArgs e)
            => AbrirForm(new ClientesForm());

        private void menuGerencia_Click(object sender, EventArgs e)
            => AbrirForm(new GerenciaForm());

        private void menuSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Sair",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
