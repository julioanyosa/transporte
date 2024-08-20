using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public record vcoordinador
{

    public string vusuario_coordinador { get; init; }
    public string vdni_coordinador { get; init; }
    public DateTime? dfecha_coordinador { get; init; }

    public vcoordinador(string _vusuario_coordinador, string _vdni_coordinador, DateTime _dfecha_coordinador)
    {
        vusuario_coordinador = _vusuario_coordinador;
        vdni_coordinador = _vdni_coordinador;
        dfecha_coordinador = _dfecha_coordinador;
    }

    public static vcoordinador Create(string _vusuario_coordinador, string _vdni_coordinador, DateTime _dfecha_coordinador)
    {
        if (string.IsNullOrWhiteSpace(_vusuario_coordinador))
        {
            throw new InvalidOperationException("La descripción de usuario no puede ser nula o vacia");
        }
        if (string.IsNullOrWhiteSpace(_vdni_coordinador))
        {
            throw new InvalidOperationException("El DNI del usuario no puede ser nula o vacia");
        }
        return new vcoordinador(_vusuario_coordinador, _vdni_coordinador, _dfecha_coordinador);
    }


}