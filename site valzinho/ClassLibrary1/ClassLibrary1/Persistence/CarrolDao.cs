using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class CarroldDao : Conexao
    {
        //inserir
        public void gravarcarro(ncarro c)
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("insert into TB_NCARRO (descricao,caminho1,caminho2) values (@v1,@v2,@v3)", con);
                cmd.Parameters.AddWithValue("@v1", c.descricao);
                cmd.Parameters.AddWithValue("@v2", c.caminho1);
                cmd.Parameters.AddWithValue("@v3", c.caminho2);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar cliente: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<ncarro> Listar()
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("select * from TB_NCARRO", con);

                Dr = cmd.ExecuteReader();
                List<ncarro> lista = new List<ncarro>();
                while (Dr.Read())
                {
                    ncarro c = new ncarro();

                    c.cod = Convert.ToInt32(Dr["ncarro_cod"]);
                    c.descricao= Convert.ToString(Dr["descricao"]);
                    c.caminho1 = Convert.ToString(Dr["caminho1"]);
                    c.caminho2 = Convert.ToString(Dr["caminho2"]);
                    
                    lista.Add(c);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("erro ao listar todos" + ex);
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
