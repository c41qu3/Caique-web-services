using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence 
{
    public class PessoaDAL : Conexao
    {
        //inserir
         public void gravar(Carro c) {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("insert into Carro (Modelo,Km,Combustivel,Cambio,FinalPlaca,Ano,Cor,Preco,Foto1,Foto2,Foto3,Foto4,Foto5,Foto6,Opcao) values (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13,@v14,@v15)", con);
                cmd.Parameters.AddWithValue("@v1", c.Modelo);
                cmd.Parameters.AddWithValue("@v2", c.Km);
                cmd.Parameters.AddWithValue("@v3", c.Combustivel);
                cmd.Parameters.AddWithValue("@v4", c.Cambio);
                cmd.Parameters.AddWithValue("@v5", c.FinalPlaca);
                cmd.Parameters.AddWithValue("@v6", c.Ano);
                cmd.Parameters.AddWithValue("@v7", c.Cor);
                cmd.Parameters.AddWithValue("@v8", c.Preco);
                cmd.Parameters.AddWithValue("@v9", c.Foto1);
                cmd.Parameters.AddWithValue("@v10", c.Foto2);
                cmd.Parameters.AddWithValue("@v11", c.Foto3);
                cmd.Parameters.AddWithValue("@v12", c.Foto4);
                cmd.Parameters.AddWithValue("@v13", c.Foto5);
                cmd.Parameters.AddWithValue("@v14", c.Foto6);
                cmd.Parameters.AddWithValue("@v15", c.opcao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar cliente: "+ex.Message);
            }
            finally {
                FecharConexao();
            }
        }
         public void Atualizar(Carro c)
         {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("update Carro set Nome = @v1, Endereco = @v2 , Email= @v3 where codigo =@v4",con);

                cmd.Parameters.AddWithValue("@v1", c.Modelo);
                cmd.Parameters.AddWithValue("@v2", c.Km);
                cmd.Parameters.AddWithValue("@v3", c.Combustivel);
                cmd.Parameters.AddWithValue("@v4", c.Cambio);
                cmd.Parameters.AddWithValue("@v5", c.FinalPlaca);
                cmd.Parameters.AddWithValue("@v6", c.Ano);
                cmd.Parameters.AddWithValue("@v7", c.Cor);
                cmd.Parameters.AddWithValue("@v8", c.Preco);
                cmd.Parameters.AddWithValue("@v9", c.Foto1);
                cmd.Parameters.AddWithValue("@v10", c.Foto2);
                cmd.Parameters.AddWithValue("@v11", c.Foto3);
                cmd.Parameters.AddWithValue("@v12", c.Foto4);
                cmd.Parameters.AddWithValue("@v13", c.Foto5);
                cmd.Parameters.AddWithValue("@v14", c.Foto6);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao atualizar o cliente");
            }
            finally {
                FecharConexao();
            }
         }
         public void Excluir(int Codigo)
        
         {
             try
             {
                 AbrirConexao();
                 cmd = new SqlCommand("delete from Carro where Codigo = @v1",con);
                 cmd.Parameters.AddWithValue("@v1", Codigo);
                 cmd.ExecuteNonQuery();
             }
             catch (Exception ex)
             {
                throw new Exception("erro ao deletar carro"+ex.Message) ;
             }
             finally {
                 FecharConexao();
             }
         }
         public Carro BuscarPorCodigo(int Codigo) {
             try
             {
                 AbrirConexao();
                 cmd = new SqlCommand("Select * from Carro where Codigo = @v1", con);
                 cmd.Parameters.AddWithValue("@v1", Codigo);

                 Dr = cmd.ExecuteReader();
                 Carro p = null;
                 if (Dr.Read()) {
                     p = new Carro();
                     p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                     p.Modelo = Convert.ToString(Dr["Nome"]);
                     p.Km = Convert.ToString(Dr["Endereco"]);
                     p.Combustivel = Convert.ToString(Dr["Email"]);
                 }
                 return p;
             }
             catch (Exception ex)
             {

                 throw new Exception("erro ao pesquisar"+ex.Message);
             }
             finally {
                 FecharConexao();
             }
         }
         public List<Carro> Listar() {
             try
             {
                 AbrirConexao();
                 cmd = new SqlCommand("select * from Carro", con);

                 Dr = cmd.ExecuteReader();
                 List<Carro> lista = new List<Carro>();
                 while(Dr.Read()){
                    Carro c = new Carro();

                    c.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    c.Modelo = Convert.ToString(Dr["Modelo"]);
                    c.Km = Convert.ToString(Dr["Km"]);
                    c.Combustivel = Convert.ToString(Dr["Combustivel"]);
                    c.Cambio = Convert.ToString(Dr["Cambio"]);
                    c.FinalPlaca = Convert.ToString(Dr["FinalPlaca"]);
                    c.Ano = Convert.ToString(Dr["Ano"]);
                    c.Cor = Convert.ToString(Dr["Cor"]);
                    c.Preco = Convert.ToString(Dr["Preco"]);
                    c.Foto1 = (byte[])Dr["Foto1"];
                    c.Foto2 = (byte[])Dr["Foto2"];
                    c.Foto3 = (byte[])Dr["Foto3"];
                    c.Foto4 = (byte[])Dr["Foto4"];
                    c.Foto5 = (byte[])Dr["Foto5"];
                    c.Foto6 = (byte[])Dr["Foto6"];
                    c.opcao = Convert.ToString(Dr["Opcao"]);
                    lista.Add(c);
                 }
                 return lista;
             }
             catch (Exception ex)
             {

                 throw new Exception("erro ao listar todos" +ex);
             }
             finally {
                 FecharConexao();
             }    
        }
    }
}
