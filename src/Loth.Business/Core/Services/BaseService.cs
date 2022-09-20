using FluentValidation;
using FluentValidation.Results;
using Loth.Business.Core.Models;
using Loth.Business.Core.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loth.Business.Core.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        public BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar (string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        //executa validaçao para qualquer Entidade que TV é validaçao que precisa herdar do TE generico que por si deve ser uma Entity
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);
            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }
    }
}
