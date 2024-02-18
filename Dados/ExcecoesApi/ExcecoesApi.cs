using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace Dados.ExcecoesApi
{
    public class ExcecoesApi : ExceptionFilter
    {
        public override void Erro(ExecutionContext context)
        {
            var excecao = context.Excecoes;
            var statusCode = 500;

            if (excecao is NotFoundExeption)
            {
                statusCode = 404;
            }

            context.Result = new ObjectResult(excecao.Message)
            { StatusCode = statusCode };
        }

    }

    
}
