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
            var s = value?.ToString();
            if (string.IsNullOrWhiteSpace(s)) return false;

            // si envías chasis: true si ya existe
            var existsByChasis = _context.ExistsByChasisAsync(s).GetAwaiter().GetResult();
            if (existsByChasis) return true;

            // si envías motor: true si ya existe
            var existsByMotor = _context.ExistsByMotorAsync(s).GetAwaiter().GetResult();
            return existsByMotor;
        }
    }
}
