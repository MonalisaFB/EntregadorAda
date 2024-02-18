using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.Models;

namespace Dados.Repositorio
{
    public interface IEntregadorRepositorio
    {
        EntregadorModel? ConsultarCpf(string cpf);
        EntregadorModel CadastrarEntregador(EntregadorModel entregador);
    }
}
