using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record codigo
{

    public string Value { get; init; }

    public codigo(string _value)
    {
        Value = _value;
    }

    public static codigo Create(string _value)
    {
        if (string.IsNullOrWhiteSpace(_value))
        {
            throw new InvalidOperationException("El código no puede ser vacio");
        }
        return new codigo(_value);
    }


}