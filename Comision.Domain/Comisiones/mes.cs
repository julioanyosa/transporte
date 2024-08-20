using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record Mes
{

    public string Value { get; init; }

    public Mes(string _value)
    {
        Value = _value;
    }

    public static Mes Create(string _value)
    {
        if (string.IsNullOrWhiteSpace(_value))
        {
            throw new InvalidOperationException("El mes no puede ser vacio");
        }
        return new Mes(_value);
    }


}