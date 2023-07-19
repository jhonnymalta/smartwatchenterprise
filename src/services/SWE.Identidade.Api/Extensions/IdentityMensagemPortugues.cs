using Microsoft.AspNetCore.Identity;

namespace SWE.Identidade.Api.Extensions
{
    public class IdentityMensagemPortugues : IdentityErrorDescriber
    {
        public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = "Ocorreu um erro desconhecido." }; }

        public override IdentityError PasswordMismatch () { return new IdentityError { Code = nameof(PasswordMismatch), Description = "Senha Incorreta." }; }

        public override IdentityError LoginAlreadyAssociated() { return new IdentityError { Code = nameof(LoginAlreadyAssociated), Description = "Este usuário já está sendo usado." }; }

    }
}
