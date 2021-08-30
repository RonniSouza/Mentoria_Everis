using EverisStore.Domain.Entities;
using FluentValidation;

namespace Manager.Domain.Validators
{
    public class ProdutoValidator : AbstractValidator<Produtos>
    {
        public ProdutoValidator()
        {
            //validação com fluentvalidation
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia.")

                .NotNull()
                .WithMessage("A entidade não pode ser nula.");

            RuleFor(x=> x.Name)
                .NotNull()
                .WithMessage("O nome não pode ser nulo.")

                .NotEmpty()
                .WithMessage("O nome não pode ser vazio.")

                .MinimumLength(3)
                .WithMessage("O nome deve ter no mínimo 3 caracteres.")
                
                .MaximumLength(80)
                .WithMessage("O nome deve ter no mãximo 80 caracteres.");

            RuleFor(x => x.Marca)
                .NotNull()
                .WithMessage("O email não pode ser nulo.")

                .NotEmpty()
                .WithMessage("O nome não pode ser vazio.")

                .MinimumLength(3)
                .WithMessage("A marca deve ter no mínimo 30 caracteres.")

                .MaximumLength(30)
                .WithMessage("O nome deve ter no máximo 80 caracteres.");

            RuleFor(x => x.Descricao)
                .NotNull()
                .WithMessage("A descricao não pode ser nula")

                .MinimumLength(20)
                .WithMessage("A descrição deve ter no mínimo 20 caracteres")

                .MaximumLength(100)
                .WithMessage("A descrição deve ter no mínimo 100 caracteres");

        }
    }
}