using Comision.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Roles;
public static class RolErrores
{
    public static Error NoEncontrado = new
    (
        "Rol.NoEncontrado",
        "No se encontro el rol"
    );
}