using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Application.Comisiones.GetComision;
 
public sealed record ComisionResponse
(
    Guid Id,
    string Nombres,
    string NombreUsuario,
    string ApellidoPaterno,
    string ApellidoMaterno,
    string Rol,
    string CorreoElectronico,
    string Pais,
    string Ciudad,
    string Provincia,
    string Distrito,
    string Calle,
    string Estado,
    DateTime FechaUltimoCambio
);