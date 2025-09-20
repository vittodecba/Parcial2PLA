using Core.Domain.Validators;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    /// <summary>
    /// Creacion del validador de la entidad Automovil para las obligaciones, lo que si o si debe tener el automovil a la hora
    /// de generarlo, es decir donde definímos las reglas de negocio para validar la entidad.
    /// </summary>
    public class AutomovilValidator : EntityValidator<Automovil>
    {

    }
}
