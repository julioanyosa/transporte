using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Roles;
public class Rol
{
    private Rol(NombreRol? nombreRol, Descripcion? descripcion)
    {
        NombreRol = nombreRol;
        Descripcion = descripcion;
    }

    public NombreRol? NombreRol { get; private set; }
    public Descripcion? Descripcion { get; private set; }

    public static Rol Create(
        NombreRol? nombreRol,
        Descripcion? descripcion
    )
    {
        var rol = new Rol(nombreRol, descripcion);
        return rol;
    }



}