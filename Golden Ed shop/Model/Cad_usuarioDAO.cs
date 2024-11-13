using Golden_Ed_shop.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golden_Ed_shop.Model
{
    internal class Cad_usuarioDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }

        public Cad_usuarioDAO() //metodo construtor
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(Usuario id)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO dbo.usuario VALUES (@code, @nome, @email, @cartaodecredito, @senha, @dtnas, @cvv, @cpf, @cep, @Ende)";

            Command.Parameters.AddWithValue("@code", id.Codcliente);
            Command.Parameters.AddWithValue("@nome", id.Nome);
            Command.Parameters.AddWithValue("@email", id.Email);
            Command.Parameters.AddWithValue("@cartaodecredito", id.CartaodeCredito);
            Command.Parameters.AddWithValue("@senha", id.Senha);
            Command.Parameters.AddWithValue("@dtnas", id.DatadeNascimento);
            Command.Parameters.AddWithValue("@cvv", id.CVV);
            Command.Parameters.AddWithValue("@cpf", id.CPF);
            Command.Parameters.AddWithValue("@cep", id.CEP);
            Command.Parameters.AddWithValue("@Ende", id.Endereço);

            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir produto no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Update(Usuario id)

        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Usuario SET 
            Nome = @nome, 
            Email = @email,
            CartaodeCredito = @cartaodecredito
            Senha = @senha
            DatadeNascimento = @dtnas
            CVV = @cvv
            CPF = @cpf
            CEP = @cep
            Endereço = Ende
            where Codcliente = @code";

            Command.Parameters.AddWithValue("@code", id.Codcliente);
            Command.Parameters.AddWithValue("@nome", id.Nome);
            Command.Parameters.AddWithValue("@email", id.Email);
            Command.Parameters.AddWithValue("@cartaodecredito", id.CartaodeCredito);
            Command.Parameters.AddWithValue("@senha", id.Senha);
            Command.Parameters.AddWithValue("@dtnas", id.DatadeNascimento);
            Command.Parameters.AddWithValue("@cvv", id.CVV);
            Command.Parameters.AddWithValue("@cpf", id.CPF);
            Command.Parameters.AddWithValue("@cep", id.CEP);
            Command.Parameters.AddWithValue("@Ende", id.Endereço);

            try
            {
                Command.ExecuteNonQuery();
            }

            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }

            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Excluir(int CodProduto)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Usuario WHERE CodCliente = @code";
            Command.Parameters.AddWithValue("@code", CodProduto);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir produto no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Usuario> ListarTodosProdutos()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Usuario";

            List<Usuario> listaDeProdutos = new List<Usuario>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Usuario prod = new Usuario(

                        (int)rd["Codcliente"],
                        (string)rd["Nome"],
                        (string)rd["Email"],
                        (int)rd["Cartaodecredito"],
                        (string)rd["Senha"],
                        (System.DateTime)rd["DatadeNascimento"],
                        (int)rd["CVV"],
                        (int)rd["CPF"],
                        (int)rd["CEP"],
                        (string)rd["Endereço"]

                        );

                    listaDeProdutos.Add(prod);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar o cadastro de cliente.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return listaDeProdutos;
        }

    }

    }

