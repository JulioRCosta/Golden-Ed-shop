using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golden_Ed_shop.Model
{
    internal class Usuario
    {
        public int Codcliente { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public int CartaodeCredito { get; set; }

        public string Senha { get; set; }

        public DateTime DatadeNascimento { get; set; }

        public int CVV { get; set; }

        public int CPF { get; set; }

        public int CEP { get; set; }

        public string Endereço { get; set; }

        public Usuario(string objetive, string Nome, string Email, int CartaodeCredito, string Senha, DateTime DatadeNascimento, int CVV, int CPF, int CEP, string Endereço) 
        {
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
