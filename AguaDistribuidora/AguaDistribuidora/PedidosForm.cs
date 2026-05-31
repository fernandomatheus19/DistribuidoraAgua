using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AguaDistribuidora
{
    public partial class PedidosForm : Form
    {
        private int _idPedido = 0;

        public PedidosForm()
        {
            InitializeComponent();
        }

        private void PedidosForm_Load(object sender, EventArgs e)
        {
            cmbProduto.Items.AddRange(new string[]
            {
                "Galão 20L", "Galão 10L", "Copo 200ml (pacote)", "Filtro Refil", "Suporte/Bebedouro"
            });
            cmbStatus.Items.AddRange(new string[]
            {
                "Aguardando", "Em Entrega", "Entregue", "Cancelado"
            });
            dtpPedido.Value  = DateTime.Today;
            dtpEntrega.Value = DateTime.Today.AddDays(1);
            ListarPedidos();
        }

        private void ListarPedidos()
        {
            try
            {
                var con = new Conexao();
                var da  = new SqlDataAdapter("SELECT * FROM pedidos ORDER BY id DESC", con.AbrirConexao());
                var dt  = new DataTable();
                da.Fill(dt);
                dgvPedidos.DataSource = dt;
                con.FecharConexao();

                if (dgvPedidos.Columns.Count >= 9)
                {
                    dgvPedidos.Columns[0].HeaderText = "ID";
                    dgvPedidos.Columns[1].HeaderText = "Cliente";
                    dgvPedidos.Columns[2].HeaderText = "Telefone";
                    dgvPedidos.Columns[3].HeaderText = "Produto";
                    dgvPedidos.Columns[4].HeaderText = "Qtd";
                    dgvPedidos.Columns[5].HeaderText = "Endereço";
                    dgvPedidos.Columns[6].HeaderText = "Bairro";
                    dgvPedidos.Columns[7].HeaderText = "Dt. Pedido";
                    dgvPedidos.Columns[8].HeaderText = "Dt. Entrega";
                    dgvPedidos.Columns[9].HeaderText = "Status";
                    dgvPedidos.Columns[10].HeaderText = "Valor R$";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar pedidos:\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularValor()
        {
            decimal preco = cmbProduto.Text switch
            {
                "Galão 20L"             => 20.00m,
                "Galão 10L"             => 12.00m,
                "Copo 200ml (pacote)"   => 8.50m,
                "Filtro Refil"          => 45.00m,
                "Suporte/Bebedouro"     => 150.00m,
                _                       => 0m
            };
            if (int.TryParse(txtQuantidade.Text, out int qtd) && qtd > 0)
                txtValor.Text = (preco * qtd).ToString("F2");
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e) => CalcularValor();
        private void txtQuantidade_TextChanged(object sender, EventArgs e)       => CalcularValor();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            { MessageBox.Show("Informe o cliente!"); txtCliente.Focus(); return; }
            if (cmbProduto.SelectedIndex < 0)
            { MessageBox.Show("Selecione o produto!"); cmbProduto.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            { MessageBox.Show("Informe a quantidade!"); txtQuantidade.Focus(); return; }

            try
            {
                var con = new Conexao();
                var cmd = new SqlCommand();
                cmd.Connection = con.AbrirConexao();

                if (_idPedido == 0)
                {
                    cmd.CommandText =
                        "INSERT INTO pedidos (cliente, telefone, produto, quantidade, endereco, bairro, " +
                        "data_pedido, data_entrega, status, valor, observacao) VALUES " +
                        "(@cliente, @telefone, @produto, @quantidade, @endereco, @bairro, " +
                        "@data_pedido, @data_entrega, @status, @valor, @observacao)";
                }
                else
                {
                    cmd.CommandText =
                        "UPDATE pedidos SET cliente=@cliente, telefone=@telefone, produto=@produto, " +
                        "quantidade=@quantidade, endereco=@endereco, bairro=@bairro, " +
                        "data_pedido=@data_pedido, data_entrega=@data_entrega, status=@status, " +
                        "valor=@valor, observacao=@observacao WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", _idPedido);
                }

                cmd.Parameters.AddWithValue("@cliente",     txtCliente.Text);
                cmd.Parameters.AddWithValue("@telefone",    txtTelefone.Text);
                cmd.Parameters.AddWithValue("@produto",     cmbProduto.Text);
                cmd.Parameters.AddWithValue("@quantidade",  int.Parse(txtQuantidade.Text));
                cmd.Parameters.AddWithValue("@endereco",    txtEndereco.Text);
                cmd.Parameters.AddWithValue("@bairro",      txtBairro.Text);
                cmd.Parameters.AddWithValue("@data_pedido", dtpPedido.Value.Date);
                cmd.Parameters.AddWithValue("@data_entrega",dtpEntrega.Value.Date);
                cmd.Parameters.AddWithValue("@status",      cmbStatus.Text == "" ? "Aguardando" : cmbStatus.Text);
                cmd.Parameters.AddWithValue("@valor",       decimal.TryParse(txtValor.Text, out decimal v) ? v : 0);
                cmd.Parameters.AddWithValue("@observacao",  txtObservacao.Text);

                cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Pedido salvo com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                ListarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar:\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_idPedido == 0) { MessageBox.Show("Selecione um pedido!"); return; }

            if (MessageBox.Show("Excluir este pedido?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                var con = new Conexao();
                var cmd = new SqlCommand("DELETE FROM pedidos WHERE id=@id", con.AbrirConexao());
                cmd.Parameters.AddWithValue("@id", _idPedido);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Pedido excluído!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                ListarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) => LimparCampos();

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvPedidos.Rows[e.RowIndex];
            _idPedido            = Convert.ToInt32(row.Cells[0].Value);
            txtCliente.Text      = row.Cells[1].Value?.ToString() ?? "";
            txtTelefone.Text     = row.Cells[2].Value?.ToString() ?? "";
            cmbProduto.Text      = row.Cells[3].Value?.ToString() ?? "";
            txtQuantidade.Text   = row.Cells[4].Value?.ToString() ?? "";
            txtEndereco.Text     = row.Cells[5].Value?.ToString() ?? "";
            txtBairro.Text       = row.Cells[6].Value?.ToString() ?? "";
            if (DateTime.TryParse(row.Cells[7].Value?.ToString(), out DateTime dp)) dtpPedido.Value  = dp;
            if (DateTime.TryParse(row.Cells[8].Value?.ToString(), out DateTime de)) dtpEntrega.Value = de;
            cmbStatus.Text       = row.Cells[9].Value?.ToString() ?? "";
            txtValor.Text        = row.Cells[10].Value?.ToString() ?? "";
        }

        private void LimparCampos()
        {
            _idPedido = 0;
            txtCliente.Clear(); txtTelefone.Clear(); txtEndereco.Clear();
            txtBairro.Clear();  txtQuantidade.Clear(); txtValor.Clear();
            txtObservacao.Clear();
            cmbProduto.SelectedIndex = -1;
            cmbStatus.SelectedIndex  = -1;
            dtpPedido.Value  = DateTime.Today;
            dtpEntrega.Value = DateTime.Today.AddDays(1);
            txtCliente.Focus();
        }
    }
}
