using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record vusuario
{

    public string vusuario_ingresa { get; init; }
    public string vdni_ingresa { get; init; }

    public vusuario(string _vusuario_ingresa, string _vdni_ingresa)
    {
        vusuario_ingresa = _vusuario_ingresa;
        vdni_ingresa = _vdni_ingresa;
    }

    public static vusuario Create(string _vusuario_ingresa, string _vdni_ingresa)
    {
        if (string.IsNullOrWhiteSpace(_vusuario_ingresa))
        {
            throw new InvalidOperationException("La descripción de usuario no puede ser nula o vacia");
        }
        if (string.IsNullOrWhiteSpace(_vdni_ingresa))
        {
            throw new InvalidOperationException("El DNI del usuario no puede ser nula o vacia");
        }
        return new vusuario(_vusuario_ingresa, _vdni_ingresa);
    }


}