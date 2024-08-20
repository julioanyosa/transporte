using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record hora_comision
{

    public string Value { get; init; }

    public hora_comision(string _value)
    {
        Value = _value;
    }

    public static hora_comision Create(string _value)
    {
        if (string.IsNullOrWhiteSpace(_value))
        {
            throw new InvalidOperationException("La hora no puede ser vacia");
        }
        return new hora_comision(_value);
    }


}