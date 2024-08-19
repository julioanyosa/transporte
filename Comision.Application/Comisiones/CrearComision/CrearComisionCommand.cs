using Comision.Application.Abstractions.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Application.Comisiones.CrearComision;

public record CrearComisionCommand
(
    string Password
   , string Rol
   , string Nombres
   , string ApellidoPaterno
   , string ApellidoMaterno
   , DateTime FechaNacimiento
   , string Pais
   , string Departamento
   , string Provincia
   , string Ciudad
   , string Distrito
   , string Calle
   , string CorreoElectronico
) : ICommand<Guid>;