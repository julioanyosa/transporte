using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Roles;
public interface IRolRepository
{
    Task<Rol?> GetByNameAsync(string rolName, CancellationToken cancellationToken = default);
}