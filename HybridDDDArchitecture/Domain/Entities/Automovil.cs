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
    public   class Automovil : DomainEntity<string, AutomovilValidator>
    {
        public string  IdAuto { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string Color { get; set; }
        public string Año_Fabrcacion { get; set; }
        public string Numero_Motor { get; set; }
        public string Numero_Chasis { get; set; }

        public Automovil(string marca , string modelo , string color , string Año,string motor,string chasis )

        {
            IdAuto = Guid.NewGuid().ToString();
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Año_Fabrcacion = Año;
            Numero_Motor = motor;
            Numero_Chasis = chasis;

        
        
        
        }

        public void setcolor(string color)
        {
            Color = color;

        }

        public void setnumeromotor(string numero)
        {
            Numero_Motor = numero;
        }
    }
}
