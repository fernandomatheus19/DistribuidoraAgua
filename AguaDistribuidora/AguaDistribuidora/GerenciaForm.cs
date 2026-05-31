using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AguaDistribuidora
{
    public partial class GerenciaForm : Form
    {
        public GerenciaForm()
        {
            InitializeComponent();
        }

        private void GerenciaForm_Load(object sender, EventArgs e)
        {
            CarregarIndicadores();
        }

        public void CarregarIndicadores()
        {
            try
            {
                var con  = new Conexao();
                var conn = con.AbrirConexao();

                // Total de clientes
                var cmdClientes = new SqlCommand("SELECT COUNT(*) FROM clientes WHERE ativo=1", conn);
                lblTotalClientes.Text = cmdClientes.ExecuteScalar()?.ToString() ?? "0";

                // Total de produtos
                var cmdProdutos = new SqlCommand("SELECT COUNT(*) FROM produtos", conn);
                lblTotalProdutos.Text = cmdProdutos.ExecuteScalar()?.ToString() ?? "0";

                // Valor total em estoque
                var cmdEstoque = new SqlCommand("SELECT ISNULL(SUM(preco * quantidade), 0) FROM produtos", conn);
                lblValorEstoque.Text = Convert.ToDecimal(cmdEstoque.ExecuteScalar()).ToString("C2");

                // Total de pedidos
                var cmdPedidos = new SqlCommand("SELECT COUNT(*) FROM pedidos", conn);
                lblTotalPedidos.Text = cmdPedidos.ExecuteScalar()?.ToString() ?? "0";

                // Receita total (pedidos)
                var cmdReceita = new SqlCommand("SELECT ISNULL(SUM(valor), 0) FROM pedidos", conn);
                lblReceita.Text = Convert.ToDecimal(cmdReceita.ExecuteScalar()).ToString("C2");

                // Pedidos aguardando
                var cmdAguardando = new SqlCommand("SELECT COUNT(*) FROM pedidos WHERE status='Aguardando'", conn);
                lblAguardando.Text = cmdAguardando.ExecuteScalar()?.ToString() ?? "0";

                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar indicadores:\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarIndicadores();
            MessageBox.Show("Dados atualizados!", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
