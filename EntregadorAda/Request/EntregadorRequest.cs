using System.ComponentModel.DataAnnotations;

namespace EntregadorAda.Request
{
    public class EntregadorRequest
    {
        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set;}

        public string Veiculo { get; set;}
        public string Cidade { get; set; }
        public string estado { get; set; }
        public string Estado { get; set; }
        public string email { get; set; }
        public string Email { get;  set; }
        public DateTime Nascimento { get; set; }

    }
}
