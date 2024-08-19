using Comision.Application.Abstractions.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Application.Comisiones.GetComision;

public sealed record GetComisionQuery(Guid UsuarioId) : IQuery<UsuarioResponse>;