using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class Cavalodal : Conexao
    {
        //inserir
        public void gravarcavalo(ncavalo c)
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("insert into TB_NCAVALO (descricao,caminho1,cod_codtipo) values (@v1,@v2,@v3)", con);
                cmd.Parameters.AddWithValue("@v1", c.descricao);
                cmd.Parameters.AddWithValue("@v2", c.caminho1);
                cmd.Parameters.AddWithValue("@v3", c.cod_tipo);
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

        public List<ncavalo> Listar()
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("select * from TB_NCAVALO", con);

                Dr = cmd.ExecuteReader();
                List<ncavalo> lista = new List<ncavalo>();
                while (Dr.Read())
                {
                    ncavalo c = new ncavalo();

                    c.cod = Convert.ToInt32(Dr["cod_cavalo"]);
                    c.descricao= Convert.ToString(Dr["descricao"]);
                    c.caminho1 = Convert.ToString(Dr["caminho1"]);
                    c.cod_tipo = Convert.ToInt32(Dr["cod_codtipo"]);
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
        public void Excluir(int cod)
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("DELETE FROM TB_NCAVALO WHERE COD_CAVALO = @v1", con);
                cmd.Parameters.AddWithValue("@v1", cod);
                Dr = cmd.ExecuteReader();
               
             
             
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
