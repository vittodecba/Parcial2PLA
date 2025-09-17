using Core.Domain.Entities;
using Domain.Validators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class Automovil : DomainEntity<string, AutomovilEntityValidator>
    {
        public int IdAuto { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año_Fabrcacion { get; set; }
        public int Numero_Motor { get; set; }
        public int Numero_Chasis { get; set; }
    }
}
