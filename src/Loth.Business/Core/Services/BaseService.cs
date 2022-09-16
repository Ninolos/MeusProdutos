using FluentValidation;
using Loth.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loth.Business.Core.Services
{
    public abstract class BaseService
    {
        //executa validaçao para qualquer Entidade que TV é validaçao que precisa herdar do TE generico que por si deve ser uma Entity
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            return validator.IsValid;
        }
    }
}
