using Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ApplicationServices
{
    public class AutomovilApplicationService(IAutomovilRepository context): IAutomovilApplivationService
        
    {
        private readonly IAutomovilRepository _context = context ?? throw new ArgumentNullException(nameof(context));
      
        public bool AutomovilExist(object value)
        {
            throw new NotImplementedException();
        }
    }
}
