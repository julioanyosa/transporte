using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record id_comision
{

    public int Value { get; init; }

    public id_comision(int _value)
    {
        Value = _value;
    }

    public static id_comision Create(int _value)
    {
        if (_value < 0)
        {
            throw new InvalidOperationException("El Id no puede ser menor a cero");
        }
        return new id_comision(_value);
    }


}