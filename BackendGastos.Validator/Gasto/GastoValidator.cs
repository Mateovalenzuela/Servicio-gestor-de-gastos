﻿using BackendGastos.Service.DTOs.Gasto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendGastos.Validator.Gasto
{
    public class GastoValidator : AbstractValidator<GastoDto>
    {
        public GastoValidator()
        {
            RuleFor(g => g.Descripcion).NotEmpty().WithMessage("La {PropertyName} es obligatoria");
            RuleFor(g => g.Descripcion).Length(2, 30).WithMessage("La {PropertyName} debe tener de 2 a 20 caracteres");

            RuleFor(g => g.Importe).NotEmpty().WithMessage("La {PropertyName} es obligatorio");
            RuleFor(g => g.Importe).GreaterThan(0).WithMessage("El {PropertyName} debe ser mayor a 0");

            RuleFor(g => g.CategoriaGastoId).NotEmpty().WithMessage("La {PropertyName} es obligatoria");
            RuleFor(g => g.CategoriaGastoId).GreaterThan(0).WithMessage("El {PropertyName} debe ser mayor a 0");

            RuleFor(g => g.SubcategoriaGastoId).NotEmpty().WithMessage("La {PropertyName} es obligatoria");
            RuleFor(g => g.SubcategoriaGastoId).GreaterThan(0).WithMessage("El {PropertyName} debe ser mayor a 0");

            RuleFor(g => g.UsuarioId).NotEmpty().WithMessage("El {PropertyName} es obligatorio");
            RuleFor(g => g.UsuarioId).GreaterThan(0).WithMessage("El {PropertyName} debe ser mayor a 0");

            RuleFor(g => g.MonedaId).NotEmpty().WithMessage("La {PropertyName} es obligatoria");
            RuleFor(g => g.MonedaId).GreaterThan(0).WithMessage("El {PropertyName} debe ser mayor a 0");
        }
    }
}
