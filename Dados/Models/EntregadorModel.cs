using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Models
{
    public class EntregadorModel
    {

        //private static int _id = 1;

        public EntregadorModel(string nome,
                               string cpf,
                               string veiculo,
                               string email,
                               DateTime nascimento,
                               string cidade,
                               string estado
                               )
        {
            //_id = _id + 1;

            Nome = nome;
            CPF = cpf;
            Veiculo = veiculo; 
            Email = email;
            Nascimento = nascimento;
            Cidade = cidade;
            Estado = estado;

        }
        //public string Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; }
        public string Veiculo { get; set; }
        public string Email { get; set; }

        public DateTime Nascimento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


    }
}
