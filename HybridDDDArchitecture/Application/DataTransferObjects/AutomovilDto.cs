using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObjects
{
    public class AutomovilDto
    {

        public string IdAuto { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string Color { get; set; }
        public string Año_Fabrcacion { get; set; }
        public string Numero_Motor { get; set; }
        public string Numero_Chasis { get; set; }
    }
}
