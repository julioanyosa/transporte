using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record mes
{

    public string Value { get; init; }

    public mes(string _value)
    {
        Value = _value;
    }

    public static mes Create(string _value)
    {
        if (string.IsNullOrWhiteSpace(_value))
        {
            throw new InvalidOperationException("El mes no puede ser vacio");
        }
        return new mes(_value);
    }


}