using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Golden_Ed_shop.Model
{
    internal class Broker
    {
        public int Id { get; set; }
        public int Codcliente { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public int CartaodeCredito { get; set; }

        public string Senha { get; set; }

        public DateTime DatadeNascimento { get; set; }

        public int CVV { get; set; }

        public string CPF { get; set; }

        public int CEP { get; set; }

        public string Endereço { get; set; }

        public Broker(string Nome, string Email)
        {
            Nome = Nome;
            Email = Email;
        }

        public Broker(int id, int Codcliente, string Nome, string Email,
            int CartaodeCredito, string Senha, DateTime DatadeNascimento, int CVV, string CPF,
            int CEP, string Endereço) : this (Codcliente, Nome, Email, CartaodeCredito, Senha, DatadeNascimento, CVV, CPF, CEP, Endereço)
        {
            id = id;
        }

        public Broker(int Codcliente, string Nome, string Email, int CartaodeCredito, string Senha, DateTime DatadeNascimento, int CVV, string CPF, int CEP, string Endereço)
        {
            Codcliente = Codcliente;
            Nome = Nome;
            Email = Email;
            CartaodeCredito = CartaodeCredito;
            Senha = Senha;
            DatadeNascimento = DatadeNascimento;
            CVV = CVV;
            CPF = CPF;
            CEP = CEP;
            Endereço = Endereço;
        }
    }
}
