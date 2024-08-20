using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record ComisionDescripcion
{

    public string Value { get; init; }

    public ComisionDescripcion(string _value)
    {
        Value = _value;
    }

    public static ComisionDescripcion Create(string _value)
    {
        if (string.IsNullOrWhiteSpace(_value))
        {
            throw new InvalidOperationException("La descripción no puede ser nula o vacia");
        }
        return new ComisionDescripcion(_value);
    }


}