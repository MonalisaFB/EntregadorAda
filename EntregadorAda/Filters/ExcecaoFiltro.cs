using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EntregadorAda.Filters
{
    public class ExcecaoFiltro : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.Result = new ObjectResult("Ocorreu um erro. Por favor, tente novamente mais tarde!")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
    }
}
