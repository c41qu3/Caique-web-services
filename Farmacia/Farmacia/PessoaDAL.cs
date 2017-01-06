using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



public class PessoaDAL : Conexao
{
    //inserir
    public void gravar(Pessoa p)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("insert into Pessoa (Nome,Endereco,Apelido,CPF,RG,DataNasc,Telefone,Tipo,Observacao) values (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9)", con);
            cmd.Parameters.AddWithValue("@v1", p.Nome);
            cmd.Parameters.AddWithValue("@v2", p.Endereco);
            cmd.Parameters.AddWithValue("@v3", p.Apelido);
            cmd.Parameters.AddWithValue("@v4", p.CPF);
            cmd.Parameters.AddWithValue("@v5", p.RG);
            cmd.Parameters.AddWithValue("@v6", p.DataNasc);
            cmd.Parameters.AddWithValue("@v7", p.Telefone);
            cmd.Parameters.AddWithValue("@v8", p.Tipo);
            cmd.Parameters.AddWithValue("@v9", p.Observacao);

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
    public void UpdatePessoa(Pessoa p)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("UPDATE Pessoa SET Nome = @v1,Endereco = @v2, Apelido = @v3, CPF=@v4,RG=@v5,DataNasc=@v6,Telefone=@v7,Tipo=@v8,Observacao=@v9 WHERE Cod_divida = @v10", con);
            cmd.Parameters.AddWithValue("@v1", p.Nome);
            cmd.Parameters.AddWithValue("@v2", p.Endereco);
            cmd.Parameters.AddWithValue("@v3", p.Apelido);
            cmd.Parameters.AddWithValue("@v4", p.CPF);
            cmd.Parameters.AddWithValue("@v5", p.RG);
            cmd.Parameters.AddWithValue("@v6", p.DataNasc);
            cmd.Parameters.AddWithValue("@v7", p.Telefone);
            cmd.Parameters.AddWithValue("@v8", p.Tipo);
            cmd.Parameters.AddWithValue("@v9", p.Observacao);
            cmd.Parameters.AddWithValue("@v10", p.Cod_divida);

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

    public void gravarlixo(Lixo l)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("insert into Lixeira (Nome_Cliente,Produto,Data_Pagamento,Valor_Pago) values (@v1,@v2,@v3,@v4)", con);
            cmd.Parameters.AddWithValue("@v1", l.Nome_Cliente);
            cmd.Parameters.AddWithValue("@v2", l.Produto);
            cmd.Parameters.AddWithValue("@v3", l.Data_Pagamento);
            cmd.Parameters.AddWithValue("@v4", l.Valor_Pago);
           
            
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
    public List<Lixo> ListarLixo()
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("Select * from Lixeira", con);
            

            Dr = cmd.ExecuteReader();
            List<Lixo> lista = new List<Lixo>();
            while (Dr.Read())
            {
                Lixo l = new Lixo();

                l.Nome_Cliente = Convert.ToString(Dr["Nome_Cliente"]);
                l.Produto = Convert.ToString(Dr["Produto"]);
                l.Data_Pagamento = Convert.ToString(Dr["Data_Pagamento"]);
                l.Valor_Pago = Convert.ToDecimal(Dr["Valor_Pago"]);
                l.Cod_Lixeira = Convert.ToInt32(Dr["Cod_Lixeira"]);
               

                lista.Add(l);
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

    /*
         public void Atualizar(Pessoa c)
         {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("update Pessoa set Nome = @v1, Endereco = @v2 , Email= @v3 where codigo =@v4",con);

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
                 cmd = new SqlCommand("delete from Pessoa where Codigo = @v1",con);
                 cmd.Parameters.AddWithValue("@v1", Codigo);
                 cmd.ExecuteNonQuery();
             }
             catch (Exception ex)
             {
                throw new Exception("erro ao deletar cliente"+ex.Message) ;
             }
             finally {
                 FecharConexao();
             }
         }
            */
    public Pessoa BuscarPorNome(String Nome)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("Select * from Pessoa where Nome like @v1", con);
            cmd.Parameters.AddWithValue("@v1","%"+Nome+"%");

            Dr = cmd.ExecuteReader();
            Pessoa p = null;
            if (Dr.Read())
            {
                p = new Pessoa();

                p.Nome = Convert.ToString(Dr["Nome"]);
                p.Endereco = Convert.ToString(Dr["Endereco"]);
                p.Apelido = Convert.ToString(Dr["Apelido"]);
                p.CPF = Convert.ToString(Dr["CPF"]);
                p.RG = Convert.ToString(Dr["RG"]);
                p.DataNasc = Convert.ToString(Dr["DataNasc"]);
                p.Telefone = Convert.ToString(Dr["Telefone"]);
                p.Tipo = Convert.ToString(Dr["Tipo"]);
                p.Observacao = Convert.ToString(Dr["Observacao"]);
                p.Cod_divida = Convert.ToInt32(Dr["Cod_divida"]);
            }
            return p;
        }
        catch (Exception ex)
        {

            throw new Exception("erro ao pesquisar" + ex.Message);
        }
        finally
        {
            FecharConexao();
        }
    }

    public List<Pessoa> ListarPessoas(String Nome)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("Select * from Pessoa where Nome like @v1", con);
            cmd.Parameters.AddWithValue("@v1","%"+Nome+"%");

            Dr = cmd.ExecuteReader();
            List<Pessoa> lista = new List<Pessoa>();
            while (Dr.Read())
            {
                Pessoa p = new Pessoa();

                p.Nome = Convert.ToString(Dr["Nome"]);
                p.Endereco = Convert.ToString(Dr["Endereco"]);
                p.Apelido = Convert.ToString(Dr["Apelido"]);
                p.CPF = Convert.ToString(Dr["CPF"]);
                p.RG = Convert.ToString(Dr["RG"]);
                p.DataNasc = Convert.ToString(Dr["DataNasc"]);
                p.Telefone = Convert.ToString(Dr["Telefone"]);
                p.Tipo = Convert.ToString(Dr["Tipo"]);
                p.Observacao = Convert.ToString(Dr["Observacao"]);
                p.Cod_divida = Convert.ToInt32(Dr["Cod_divida"]);

                lista.Add(p);
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
    public List<Pessoa> ListarPessoasporcpf(String CPF)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("Select * from Pessoa where CPF like @v1", con);
            cmd.Parameters.AddWithValue("@v1", "%" + CPF + "%");

            Dr = cmd.ExecuteReader();
            List<Pessoa> lista = new List<Pessoa>();
            while (Dr.Read())
            {
                Pessoa p = new Pessoa();

                p.Nome = Convert.ToString(Dr["Nome"]);
                p.Endereco = Convert.ToString(Dr["Endereco"]);
                p.Apelido = Convert.ToString(Dr["Apelido"]);
                p.CPF = Convert.ToString(Dr["CPF"]);
                p.RG = Convert.ToString(Dr["RG"]);
                p.DataNasc = Convert.ToString(Dr["DataNasc"]);
                p.Telefone = Convert.ToString(Dr["Telefone"]);
                p.Tipo = Convert.ToString(Dr["Tipo"]);
                p.Observacao = Convert.ToString(Dr["Observacao"]);
                p.Cod_divida = Convert.ToInt32(Dr["Cod_divida"]);

                lista.Add(p);
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

    public List<Pessoa> ListarPessoasporApelido(String Apelido)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("Select * from Pessoa where Apelido like @v1", con);
            cmd.Parameters.AddWithValue("@v1", "%" + Apelido + "%");

            Dr = cmd.ExecuteReader();
            List<Pessoa> lista = new List<Pessoa>();
            while (Dr.Read())
            {
                Pessoa p = new Pessoa();

                p.Nome = Convert.ToString(Dr["Nome"]);
                p.Endereco = Convert.ToString(Dr["Endereco"]);
                p.Apelido = Convert.ToString(Dr["Apelido"]);
                p.CPF = Convert.ToString(Dr["CPF"]);
                p.RG = Convert.ToString(Dr["RG"]);
                p.DataNasc = Convert.ToString(Dr["DataNasc"]);
                p.Telefone = Convert.ToString(Dr["Telefone"]);
                p.Tipo = Convert.ToString(Dr["Tipo"]);
                p.Observacao = Convert.ToString(Dr["Observacao"]);
                p.Cod_divida = Convert.ToInt32(Dr["Cod_divida"]);

                lista.Add(p);
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
    //inserir Divida
    public void gravarDivida(Divida d)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("insert into Divida (Cod_divida,Quantidade,Produto,Data,Comprador,Preco) values (@v1,@v2,@v3,@v4,@v5,@v6)", con);
            cmd.Parameters.AddWithValue("@v1", d.Cod_divida);
            cmd.Parameters.AddWithValue("@v2", d.Quantidade);
            cmd.Parameters.AddWithValue("@v3", d.Produto);
            cmd.Parameters.AddWithValue("@v4", d.Data);
            cmd.Parameters.AddWithValue("@v5", d.Comprador);
            cmd.Parameters.AddWithValue("@v6", d.preco);
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

    public Divida BuscarDivida(int Cod_divida)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("Select * from Divida where Cod_divida = @v1", con);
            cmd.Parameters.AddWithValue("@v1", Cod_divida);

            Dr = cmd.ExecuteReader();
            Divida d = new Divida();
            if (Dr.Read())
            {
                d.Quantidade = Convert.ToInt32(Dr["quantidade"]);
                d.Produto = Convert.ToString(Dr["Produto"]);
                d.Data = Convert.ToString(Dr["Data"]);
                d.Comprador = Convert.ToString(Dr["Comprador"]);
                d.preco = Convert.ToDecimal(Dr["Preco"]);

            }
            return d;
        }
        catch (Exception ex)
        {

            throw new Exception("erro ao pesquisar" + ex.Message);
        }
        finally
        {
            FecharConexao();
        }
    }

    public List<Divida> ListarDividas(int Cod_divida) {
                 try
                 {
                     AbrirConexao();
                      List<Divida> lista = new List<Divida>();
                     cmd = new SqlCommand("select * from Divida where Cod_divida = @v1 ", con);
                     cmd.Parameters.AddWithValue("@v1", Cod_divida);

                     Dr = cmd.ExecuteReader();
                    
                     while(Dr.Read()){
                        Divida d = new Divida();

                        d.Cod_divida = Convert.ToInt32(Dr["Cod_divida"]);
                        d.Quantidade = Convert.ToInt32(Dr["Quantidade"]);
                        d.Produto = Convert.ToString(Dr["Produto"]);
                        d.Data = Convert.ToString(Dr["Data"]);
                        d.Comprador = Convert.ToString(Dr["Comprador"]);
                        d.preco = Convert.ToDecimal(Dr["Preco"]);
                        d.Cod_deleta = Convert.ToInt32(Dr["Cod_deleta"]);
                        lista.Add(d);


                     }
                     return lista;
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
    public void DeletaDividasDoCliente(int Cod_divida)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("DELETE FROM Divida where Cod_divida = @v1  ", con);
            cmd.Parameters.AddWithValue("@v1", Cod_divida);
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
    public void DeletaItem(int Cod_deleta)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("DELETE FROM Divida where Cod_deleta = @v1 ", con);
            cmd.Parameters.AddWithValue("@v1", Cod_deleta);
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
    public List<Divida> ListarTodasDividas()
    {
        try
        {
            AbrirConexao();
            List<Divida> lista = new List<Divida>();
            cmd = new SqlCommand("select * from Divida  ", con);
            

            Dr = cmd.ExecuteReader();

            while (Dr.Read())
            {
                Divida d = new Divida();

                d.Cod_divida = Convert.ToInt32(Dr["Cod_divida"]);
                d.Quantidade = Convert.ToInt32(Dr["Quantidade"]);
                d.Produto = Convert.ToString(Dr["Produto"]);
                d.Data = Convert.ToString(Dr["Data"]);
                d.Comprador = Convert.ToString(Dr["Comprador"]);
                d.preco = Convert.ToDecimal(Dr["Preco"]);
                d.Cod_deleta = Convert.ToInt32(Dr["Cod_deleta"]);
                lista.Add(d);


            }
            return lista;
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
    public Pessoa BuscarPorcod_divida(int Cod_divida)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("Select * from Pessoa where Cod_divida = @v1", con);
            cmd.Parameters.AddWithValue("@v1", Cod_divida);

            Dr = cmd.ExecuteReader();
            Pessoa p = null;
            if (Dr.Read())
            {
                p = new Pessoa();

                p.Nome = Convert.ToString(Dr["Nome"]);
                p.Endereco = Convert.ToString(Dr["Endereco"]);
                p.Apelido = Convert.ToString(Dr["Apelido"]);
                p.CPF = Convert.ToString(Dr["CPF"]);
                p.DataNasc = Convert.ToString(Dr["DataNasc"]);
                p.Telefone = Convert.ToString(Dr["Telefone"]);
                p.Tipo = Convert.ToString(Dr["Tipo"]);
                p.Observacao = Convert.ToString(Dr["Observacao"]);
                p.Cod_divida = Convert.ToInt32(Dr["Cod_divida"]);
            }
            return p;
        }
        catch (Exception ex)
        {

            throw new Exception("erro ao pesquisar" + ex.Message);
        }
        finally
        {
            FecharConexao();
        }
    } 

    //inserir promocao
    public void gravarPromocao(Promocao p)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("insert into Promocoes (Nome,precoCompra,precoVenda) values (@v1,@v2,@v3)", con);
            cmd.Parameters.AddWithValue("@v1", p.Nome);
            cmd.Parameters.AddWithValue("@v2", p.precoCompra);
            cmd.Parameters.AddWithValue("@v3", p.precoVenda);
          

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
    public List<Promocao> ListarTodasAsPromocoes()
    {
        try
        {
            AbrirConexao();
            List<Promocao> lista = new List<Promocao>();
            cmd = new SqlCommand("select * from Promocoes  ", con);


            Dr = cmd.ExecuteReader();

            while (Dr.Read())
            {
                Promocao p = new Promocao();

               p.Nome = Convert.ToString(Dr["Nome"]);
               p.precoCompra = Convert.ToDecimal(Dr["precoCompra"]);
               p.precoVenda= Convert.ToDecimal(Dr["PrecoVenda"]);
               p.Codigo = Convert.ToInt32(Dr["Codigo"]); 
               lista.Add(p);
             }

            return lista;
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
    public void DeletaItemPromocao(int Codigo)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("DELETE FROM Promocoes where Codigo = @v1 ", con);
            cmd.Parameters.AddWithValue("@v1", Codigo);
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

    //métodos das duplicatas
    public void gravarDuplicata(Duplicata d)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("insert into Duplicatas (Empresa,NotaFiscal,Emissao,Vencimento,Duplicatas, Valorapagar) values (@v1,@v2,@v3,@v4,@v5,@v6)", con);
            cmd.Parameters.AddWithValue("@v1", d.Empresa);
            cmd.Parameters.AddWithValue("@v2", d.NotaFiscal);
            cmd.Parameters.AddWithValue("@v3", d.Emissao);
            cmd.Parameters.AddWithValue("@v4", d.Vencimento);
            cmd.Parameters.AddWithValue("@v5", d.Duplicatas);
            cmd.Parameters.AddWithValue("@v6", d.ValoraPagar);


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

    public List<Duplicata> ListarTodasAsDuplicatas()
    {
        try
        {
            AbrirConexao();
            List<Duplicata> lista = new List<Duplicata>();
            cmd = new SqlCommand("select * from Duplicatas", con);


            Dr = cmd.ExecuteReader();

            while (Dr.Read())
            {
                Duplicata d = new Duplicata();

                d.Empresa = Convert.ToString(Dr["Empresa"]);
                d.NotaFiscal = Convert.ToString(Dr["NotaFiscal"]);
                d.Emissao = Convert.ToString(Dr["Emissao"]);
                d.Vencimento = Convert.ToString(Dr["Vencimento"]);
                d.Duplicatas = Convert.ToString(Dr["Duplicatas"]);
                d.ValoraPagar = Convert.ToDecimal(Dr["ValoraPagar"]);
                d.codigo = Convert.ToInt32(Dr["Codigo"]);
                lista.Add(d);
            }

            return lista;
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
    public void DeletaItemDuplicata(int Codigo)
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("DELETE FROM Duplicatas where Codigo = @v1 ", con);
            cmd.Parameters.AddWithValue("@v1", Codigo);
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
    public Decimal SomaDividas()
    {
        try
        {
            AbrirConexao();
            cmd = new SqlCommand("Select SUM(Preco) as preco from Divida", con);

            Dr = cmd.ExecuteReader();
            String i = "0";
            Decimal a = 0;
            if (Dr.Read())
            {

                 i = Convert.ToString(Dr["preco"]);
                 if (i.Equals(""))
                 {
                     return 0;
                 }
                 a = Convert.ToDecimal(i);
               
            }
            
            return a;
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
