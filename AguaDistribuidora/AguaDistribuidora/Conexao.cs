using Microsoft.Data.SqlClient;
using System.Data;

namespace AguaDistribuidora
{
    public class Conexao
    {
        // Código corrigido para usar a sua conta do Windows (Matheus)
        private readonly string _connectionString =
            "Server=DESKTOP-GCCKJ44;" +    // <-- Coloquei o nome exato do seu Servidor
            "Database=AguaDistribuidora;" +
            "Integrated Security=True;" +  // <-- Isto substitui o User Id e a Password e usa o seu Windows
            "TrustServerCertificate=True;";

        private SqlConnection? _con;

        public SqlConnection AbrirConexao()
        {
            _con = new SqlConnection(_connectionString);
            if (_con.State == ConnectionState.Closed)
                _con.Open();
            return _con;
        }

        public void FecharConexao()
        {
            if (_con != null && _con.State == ConnectionState.Open)
                _con.Close();
        }
    }
}