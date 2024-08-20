using Comision.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;
public record Correo_Sec
{
    public string Value { get; init; }

    private Correo_Sec(string value)
    {
        Value = value;
    }

    public static Result<Correo_Sec> Create(string _value)
    {
        if (EsCorreoValido(_value))
        {
            return new Correo_Sec(_value);
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
