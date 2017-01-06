using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL.Persistence
{
    public class Conexao
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader Dr;

        protected void AbrirConexao() {
            try
            {
                var str = ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString;
                con = new SqlConnection(str);
                con.Open();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
        protected void FecharConexao(){
            try 
	        {	        
		        con.Close();
	        }
	        catch (Exception ex)
	        {
                throw new Exception(ex.Message);
	        }
        }
    }
}
