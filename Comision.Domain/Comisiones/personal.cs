using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record personal
(
    int? id_personal,
    string? nombres,
    string? dni,
    string? siglas_personal,
    int? idarea_personal
    );