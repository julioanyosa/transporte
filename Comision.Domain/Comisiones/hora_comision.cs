using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record Hora_Comision
{

    public string Value { get; init; }

    public Hora_Comision(string _value)
    {
        Value = _value;
    }

    public static Hora_Comision Create(string _value)
    {
        if (string.IsNullOrWhiteSpace(_value))
        {
            throw new InvalidOperationException("La hora no puede ser vacia");
        }
        return new Hora_Comision(_value);
    }


}