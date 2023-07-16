using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace SWE.Identidade.Api.Model
{
    public class UsuarioRegistro
    {
        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage ="O campo {0} não é um formato válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100,ErrorMessage ="O campo {0} deve conter entre {2} e {1} caracteres.",MinimumLength =6)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="As senhas não conferem.")]
        public string ConfirmedPassword { get; set; }
    }

    public class UsuarioLogin
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo {0} não é um formato válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo {0} não é um formato válido.")]
        public string Password { get; set; }
    }

    public class UsuarioRespostaLogin
    {
        public string AcessToken { get; set; }
        public double ExpiresIn { get; set; }
        public UsuarioToken UsuarioToken { get; set; }
    }
    public class UsuarioToken
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<UsuarioClaim> Claims { get; set; }
    }
    public class UsuarioClaim
    {
        public string Value { get; set; }
        public string Type { get; set; }
    }
}
