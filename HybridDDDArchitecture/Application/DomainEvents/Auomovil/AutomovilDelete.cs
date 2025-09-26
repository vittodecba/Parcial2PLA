using Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DomainEvents.Auomovil
{
    public class AutomovilDelete : DomainEvent
    {
       public string Id { get; set; }

        public AutomovilDelete(string id) { Id = id; }


    }
}
