using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record Codigo
{

    public string Value { get; init; }

    public Codigo(string _value)
    {
        Value = _value;
    }

    public static Codigo Create(string _value)
    {
        if (string.IsNullOrWhiteSpace(_value))
        {
            throw new InvalidOperationException("El código no puede ser vacio");
        }
        return new Codigo(_value);
    }


}