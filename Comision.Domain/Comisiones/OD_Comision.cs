using Comision.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public class OD_Comision : Entity
{
   private OD_Comision(
       Id_Comision id_Comision,
       Personal personal,
       Id_Chofer id_Chofer,
       Id_Vehiculo id_Vehiculo,
       Codigo codigo,
       Siglas siglas,
       IdArea idarea,
       Mes mes,
       TipoViaje tipoViaje,
       ComisionDescripcion comisionDescripcion,
       Destino destino,
       Hora_Comision hora_Comision,
       Hora_Salida hora_Salida,
       Hora_Retorno hora_Retorno,
       DateTime fecha_registro,
       DateTime? fecha_salida,
       DateTime? fecha_modificacion,
       Km_Salida km_Salida,
       Km_Retorno km_Retorno,
       Telefono telefono,
       Usuario usuario,
       Cant_usuario cant_Usuario,
       Id_Usuario_Ini id_Usuario_Ini,
       Id_Usuario_Sec id_Usuario_Sec,
       Fecha_Registro_Dir fecha_Registro_Dir,
       Id_Usuario_Dir id_Usuario_Dir,
       Id_Usuario_Oga id_Usuario_Oga,
       Id_Usuario_Sup id_Usuario_Sup,
       Veh_Inicio veh_Inicio,
       //conf_oga
       Correo_Sec correo_Sec,
       Vusuario vusuario,
       Vcoordinador vcoordinador,
       Estado estado

       ) 
    {
        id_comision = id_Comision,
       personal = personal,

    , cant_usuario cant_usuario
    , ComisionDescripcion ComisionDescripcion
    , DateTime fechaNacimiento
    , DateTime fecha_salida
    , hora_comision hora_comision
    , telefono? telefono
    , Destino Destino
        , TipoViaje TipoViaje
        , id_usuario_sec? id_usuario_sec
        , siglas? siglas
        , idarea? idarea
        , correo_sec correo_Sec
        , vusuario vusuario

    }

    public Id_Comision id_comision { get; private set; }
    public Personal? personal { get; private set; }
    public Id_Chofer? id_chofer { get; private set; }
    public Id_Vehiculo? id_vehiculo { get; private set; }
    public Codigo? codigo { get; private set; }
    public Siglas? siglas { get; private set; }
    public IdArea? idarea { get; private set; }
    public Mes? mes { get; private set; }
    public TipoViaje? TipoViaje { get; private set; }
    public ComisionDescripcion? ComisionDescripcion { get; private set; }
    public Destino? Destino { get; private set; }
    public Hora_Comision? hora_comision { get; private set; }
    public Hora_Salida? hora_salida { get; private set; }
    public Hora_Retorno? hora_retorno { get; private set; }
    public DateTime fecha_registro { get; private set; }
    public DateTime? fecha_salida { get; private set; }
    public DateTime? fecha_modificacion { get; private set; }
    public Km_Salida? km_Salida { get; private set; }
    public Km_Retorno? km_retorno { get; private set; }
    public Telefono? telefono { get; private set; }
    public Usuario? usuario { get; private set; }
    public Cant_usuario? cant_usuario { get; private set; }
    public Id_Usuario_Ini? id_usuario_ini { get; private set; }
    public Id_Usuario_Sec? id_usuario_sec { get; private set; }
    public Fecha_Registro_Dir? fecha_registro_dir { get; private set; }
    public Id_Usuario_Dir? id_usuario_dir { get; private set; }
    public Id_Usuario_Oga? id_usuario_oga { get; private set; }
    public Id_Usuario_Sup? id_usuario_sup { get; private set; }
    public Veh_Inicio? veh_inicio { get; private set; }
    //public conf_og {get; private set;}
    public Correo_Sec? correo_sec { get; private set; }
    public Vusuario? vusuario { get; private set; }
    public Vcoordinador? vcoordinador { get; private set; }
    public Estado? estado { get; private set; }


    public static Comision Create(
      id_comision id_comision
    , personal personal
    , cant_usuario cant_usuario
    , ComisionDescripcion ComisionDescripcion
    , DateTime fechaNacimiento
    , DateTime fecha_salida
    , hora_comision hora_comision
    , telefono? telefono
    , Destino Destino
        ,TipoViaje TipoViaje
        , id_usuario_sec? id_usuario_sec
        , siglas? siglas
        , idarea? idarea
        , correo_sec correo_Sec
        , vusuario vusuario
    )
    {
 
        var comision = new Comision(
            Guid.NewGuid(),
            nombreUsuario,
            apellidoPaterno,
            apellidoMaterno,
            password,
            fechaNacimiento,
            correoElectronico,
            direccion,
            UsuarioEstado.Activo,
            fechaUltimoCambio
        );

        usuario.RaiseDomainEvent(new UserCreateDomainEvent(usuario.Id));

        return usuario;
    }
}


 
