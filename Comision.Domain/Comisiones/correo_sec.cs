using Comision.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;
public record correo_sec
{
    public string Value { get; init; }

    private correo_sec(string value)
    {
        Value = value;
    }

    public static Result<correo_sec> Create(string _value)
    {
        if (EsCorreoValido(_value))
        {
            return new correo_sec(_value);
        }
        throw new InvalidOperationException("El correo electronico no es valido");
    }

    private static bool EsCorreoValido(string correo)
    {
        const string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
        if (string.IsNullOrEmpty(correo))
        {
            return false;
        }

        var esCorrecto = Regex.Match(correo, emailRegex).Success;

        if (esCorrecto)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
