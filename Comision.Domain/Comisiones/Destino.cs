using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record Destino
{

    public string Value { get; init; }

    public Destino(string _value)
    {
        Value = _value;
    }

    public static Destino Create(string _value)
    {
        if (string.IsNullOrWhiteSpace(_value))
        {
            throw new InvalidOperationException("El destino no puede ser vacio");
        }
        return new Destino(_value);
    }


}