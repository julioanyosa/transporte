using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record siglas
{

    public string Value { get; init; }

    public siglas(string _value)
    {
        Value = _value;
    }

    public static siglas Create(string _value)
    {
        if (string.IsNullOrWhiteSpace(_value))
        {
            throw new InvalidOperationException("Las siglas no pueden ser vacio");
        }
        return new siglas(_value);
    }


}