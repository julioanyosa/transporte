using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record Id_Comision
{

    public int Value { get; init; }

    public Id_Comision(int _value)
    {
        Value = _value;
    }

    public static Id_Comision Create(int _value)
    {
        if (_value < 0)
        {
            throw new InvalidOperationException("El Id no puede ser menor a cero");
        }
        return new Id_Comision(_value);
    }


}