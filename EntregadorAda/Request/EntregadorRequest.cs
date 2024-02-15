using System.ComponentModel.DataAnnotations;

namespace EntregadorAda.Request
{
    public class CadastrarEntregadorRequest
    {
        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set;}
      
    }
}
