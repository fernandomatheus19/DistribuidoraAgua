using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AguaDistribuidora
{
    public partial class EstoqueForm : Form
    {
        private int _idProduto = 0;

        public EstoqueForm()
        {
            InitializeComponent();
        }

        private void EstoqueForm_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void ListarProdutos()
        {
            try
            {
                var con = new Conexao();
                var da  = new SqlDataAdapter("SELECT * FROM produtos ORDER BY nome", con.AbrirConexao());
                var dt  = new DataTable();
                da.Fill(dt);
                dgvProdutos.DataSource = dt;
                con.FecharConexao();

                if (dgvProdutos.Columns.Count >= 3)
                {
                    dgvProdutos.Columns[0].HeaderText = "ID";
                    dgvProdutos.Columns[1].HeaderText = "Produto";
                    dgvProdutos.Columns[2].HeaderText = "Quantidade";
                    dgvProdutos.Columns[3].HeaderText = "Preço Unitário";
                }

                ColorirEstoque();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar:\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ColorirEstoque()
        {
            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                if (row.Cells["quantidade"] == null) continue;
                if (int.TryParse(row.Cells["quantidade"].Value?.ToString(), out int qtd))
                {
                    if (qtd <= 5)
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200); // vermelho
                    else if (qtd <= 15)
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 245, 180); // amarelo
                    else
                        row.DefaultCellStyle.BackColor = Color.FromArgb(200, 240, 210); // verde
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            { MessageBox.Show("Informe o nome do produto!"); txtNome.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            { MessageBox.Show("Informe a quantidade!"); txtQuantidade.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtPreco.Text))
            { MessageBox.Show("Informe o preço!"); txtPreco.Focus(); return; }

            try
            {
                var con = new Conexao();
                var cmd = new SqlCommand();
                cmd.Connection = con.AbrirConexao();

                if (_idProduto == 0)
                    cmd.CommandText = "INSERT INTO produtos (nome, quantidade, preco) VALUES (@nome, @qtd, @preco)";
                else
                {
                    cmd.CommandText = "UPDATE produtos SET nome=@nome, quantidade=@qtd, preco=@preco WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", _idProduto);
                }

                cmd.Parameters.AddWithValue("@nome",  txtNome.Text);
                cmd.Parameters.AddWithValue("@qtd",   int.Parse(txtQuantidade.Text));
                cmd.Parameters.AddWithValue("@preco", decimal.Parse(txtPreco.Text));
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Produto salvo!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                ListarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_idProduto == 0) { MessageBox.Show("Selecione um produto!"); return; }

            if (MessageBox.Show("Excluir este produto?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                var con = new Conexao();
                var cmd = new SqlCommand("DELETE FROM produtos WHERE id=@id", con.AbrirConexao());
                cmd.Parameters.AddWithValue("@id", _idProduto);
                cmd.ExecuteNonQuery();
                con.FecharConexao();
                LimparCampos();
                ListarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) => LimparCampos();

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvProdutos.Rows[e.RowIndex];
            _idProduto         = Convert.ToInt32(row.Cells[0].Value);
            txtNome.Text       = row.Cells[1].Value?.ToString() ?? "";
            txtQuantidade.Text = row.Cells[2].Value?.ToString() ?? "";
            txtPreco.Text      = row.Cells[3].Value?.ToString() ?? "";
        }

        private void LimparCampos()
        {
            _idProduto = 0;
            txtNome.Clear(); txtQuantidade.Clear(); txtPreco.Clear();
            txtNome.Focus();
        }
    }
}
