using Golden_Ed_shop.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golden_Ed_shop.Model
{
    internal class BrokerDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public BrokerDAO() //método construtor
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public bool Insert(Broker broker)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO dbo.usuario VALUES (@code, @nome, @email, @cartaodecredito, @senha, @dtnas, @cvv, @cpf, @cep, @Ende)";

            Command.Parameters.AddWithValue("@code", broker.Codcliente);
            Command.Parameters.AddWithValue("@nome", broker.Nome);
            Command.Parameters.AddWithValue("@email", broker.Email);
            Command.Parameters.AddWithValue("@cartaodecredito", broker.CartaodeCredito);
            Command.Parameters.AddWithValue("@senha", broker.Senha);
            Command.Parameters.AddWithValue("@dtnas", broker.DatadeNascimento);
            Command.Parameters.AddWithValue("@cvv", broker.CVV);
            Command.Parameters.AddWithValue("@cpf", broker.CPF);
            Command.Parameters.AddWithValue("@cep", broker.CEP);
            Command.Parameters.AddWithValue("@Ende", broker.Endereço);

            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "corretor no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
            return true;
        }


        public void Update(Broker broker)
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

            Command.Parameters.AddWithValue("@code", broker.Codcliente);
            Command.Parameters.AddWithValue("@nome", broker.Nome);
            Command.Parameters.AddWithValue("@email", broker.Email);
            Command.Parameters.AddWithValue("@cartaodecredito", broker.CartaodeCredito);
            Command.Parameters.AddWithValue("@senha", broker.Senha);
            Command.Parameters.AddWithValue("@dtnas", broker.DatadeNascimento);
            Command.Parameters.AddWithValue("@cvv", broker.CVV);
            Command.Parameters.AddWithValue("@cpf", broker.CPF);
            Command.Parameters.AddWithValue("@cep", broker.CEP);
            Command.Parameters.AddWithValue("@Ende", broker.Endereço);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: " +
                    "Problemas ao realizar atualização dos dados do " +
                    "corretor no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Delete(int brokerCode)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Broker 
            WHERE Id = @Codcliente";
            Command.Parameters.AddWithValue("@brokerCode", brokerCode);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir " +
                    "cadastro do corretor do banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Broker> ListAllBrokers()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Broker";

            List<Broker> brokers = new List<Broker>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Broker broker = new Broker(
                         (int)rd["Codcliente"],
                        (string)rd["Nome"],
                        (string)rd["Email"],
                        (int)rd["Cartaodecredito"],
                        (string)rd["Senha"],
                        (System.DateTime)rd["DatadeNascimento"],
                        (int)rd["CVV"],
                        (string)rd["CPF"],
                        (int)rd["CEP"],
                        (string)rd["Endereço"]
                        );
                    brokers.Add(broker);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar " +
                    "leitura de imóveis no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return brokers;
        }
        public bool ValidateLogin(Broker broker)
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Broker WHERE " +
                                  "Nome = @nome AND " +
                                  "Email = @email";
            Command.Parameters.AddWithValue("@nome", broker.Nome);
            Command.Parameters.AddWithValue("@email", broker.Email);

            try
            {
                SqlDataReader rd = Command.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Close();
                    return true;
                }
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar " +
                    "leitura de dados do corretor no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return false;
        }
    }
}

