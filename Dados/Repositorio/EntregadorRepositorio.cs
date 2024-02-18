using Dados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Repositorio
{
    public class EntregadorRepositorio : IEntregadorRepositorio
    {
        private List<EntregadorModel> entregadores = new List<EntregadorModel>()
        {
            new EntregadorModel("Monalisa Brito", "11122233344", "Moto", "Fortaleza", "Ceará", "monaentregadora@email.com", DateTime.Now)



        };

        public EntregadorModel CadastrarEntregador(EntregadorModel entregadorModel)
        {
            entregadores.Add(entregadorModel);
            return entregadorModel;
        }

        public EntregadorModel? ConsultarCpf(string cpf)
        {
            var entregadorPorCpf = entregadores.FirstOrDefault(x => x.CPF == cpf);
            if (entregadorPorCpf == null)
            {
                //Falta o Status Code
                throw new Exception($"Entregador com cpf {cpf} não foi encontrado");
            }
            return entregadorPorCpf;
        }
    }
}
