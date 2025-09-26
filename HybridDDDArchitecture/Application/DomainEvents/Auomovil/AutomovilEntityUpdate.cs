using Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DomainEvents.Auomovil
{
    public  class AutomovilEntityUpdate : DomainEvent
    {
        private string id;

        public AutomovilEntityUpdate(string id)
        {
            this.id = id;
        }

        public string color { get; set; }
        public string Numero_mototr { get; set; }

    }
}
