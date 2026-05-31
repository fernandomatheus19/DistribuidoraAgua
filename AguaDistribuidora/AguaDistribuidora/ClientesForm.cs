using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AguaDistribuidora
{
    public partial class ClientesForm : Form
    {
        private int _idCliente = 0;

        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            try
            {
                var con = new Conexao();
                var da  = new SqlDataAdapter("SELECT * FROM clientes ORDER BY nome", con.AbrirConexao());
                var dt  = new DataTable();
                da.Fill(dt);
                dgvClientes.DataSource = dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar clientes:\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            { MessageBox.Show("Informe o nome!"); txtNome.Focus(); return; }

            try
            {
                var con = new Conexao();
                var cmd = new SqlCommand();
                cmd.Connection = con.AbrirConexao();

                if (_idCliente == 0)
                    cmd.CommandText = "INSERT INTO clientes (nome, telefone, endereco, bairro, cidade, ativo) " +
                                      "VALUES (@nome, @tel, @end, @bairro, @cidade, 1)";
                else
                {
                    cmd.CommandText = "UPDATE clientes SET nome=@nome, telefone=@tel, endereco=@end, " +
                                      "bairro=@bairro, cidade=@cidade WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", _idCliente);
                }

                cmd.Parameters.AddWithValue("@nome",   txtNome.Text);
                cmd.Parameters.AddWithValue("@tel",    txtTelefone.Text);
                cmd.Parameters.AddWithValue("@end",    txtEndereco.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Cliente salvo!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_idCliente == 0) { MessageBox.Show("Selecione um cliente!"); return; }

            if (MessageBox.Show("Excluir este cliente?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                var con = new Conexao();
                var cmd = new SqlCommand("DELETE FROM clientes WHERE id=@id", con.AbrirConexao());
                cmd.Parameters.AddWithValue("@id", _idCliente);
                cmd.ExecuteNonQuery();
                con.FecharConexao();
                LimparCampos();
                ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) => LimparCampos();

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvClientes.Rows[e.RowIndex];
            _idCliente        = Convert.ToInt32(row.Cells[0].Value);
            txtNome.Text      = row.Cells[1].Value?.ToString() ?? "";
            txtTelefone.Text  = row.Cells[2].Value?.ToString() ?? "";
            txtEndereco.Text  = row.Cells[3].Value?.ToString() ?? "";
            txtBairro.Text    = row.Cells[4].Value?.ToString() ?? "";
            txtCidade.Text    = row.Cells[5].Value?.ToString() ?? "";
        }

        private void LimparCampos()
        {
            _idCliente = 0;
            txtNome.Clear(); txtTelefone.Clear(); txtEndereco.Clear();
            txtBairro.Clear(); txtCidade.Clear();
            txtNome.Focus();
        }
    }
}
