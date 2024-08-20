using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record Siglas
{

    public string Value { get; init; }

    public Siglas(string _value)
    {
        Value = _value;
    }

    public static Siglas Create(string _value)
    {
        if (string.IsNullOrWhiteSpace(_value))
        {
            throw new InvalidOperationException("Las siglas no pueden ser vacio");
        }
        return new Siglas(_value);
    }


}