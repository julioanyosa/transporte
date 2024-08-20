using Comision.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Domain.Comisiones;

public class Comision : Entity
{
   private Comision(
       id_comision id_Comision,
       personal personal,
       id_chofer id_Chofer,
       id_vehiculo id_Vehiculo,
       codigo codigo,
       siglas siglas,
       idarea idarea,
       mes mes,
       TipoViaje tipoViaje,
       ComisionDescripcion comisionDescripcion,
       Destino destino,
       hora_comision hora_Comision,
       hora_salida hora_Salida,
       hora_retorno hora_Retorno,
       DateTime fecha_registro,
       DateTime? fecha_salida,
       DateTime? fecha_modificacion,
       km_Salida km_Salida,
       km_retorno km_Retorno,
       telefono telefono,
       usuario usuario,
       cant_usuario cant_Usuario,
       id_usuario_ini id_Usuario_Ini,
       id_usuario_sec id_Usuario_Sec,
       fecha_registro_dir fecha_Registro_Dir,
       id_usuario_dir id_Usuario_Dir,
       id_usuario_oga id_Usuario_Oga,
       id_usuario_sup id_Usuario_Sup,
       veh_inicio veh_Inicio,
       //conf_oga
       correo_sec correo_Sec,
       vusuario vusuario,
       vcoordinador vcoordinador,
       estado estado

       ) 
    {
  

    }

    public id_comision id_comision { get; private set; }
    public personal personal { get; private set; }
    public id_chofer id_chofer { get; private set; }
    public id_vehiculo id_vehiculo { get; private set; }
    public codigo codigo { get; private set; }
    public siglas siglas { get; private set; }
    public idarea idarea { get; private set; }
    public mes mes { get; private set; }
    public TipoViaje tipoViaje { get; private set; }
    public ComisionDescripcion comisionDescripcion { get; private set; }
    public Destino destino { get; private set; }
    public hora_comision hora_Comision { get; private set; }
    public hora_salida hora_Salida { get; private set; }
    public hora_retorno hora_Retorno { get; private set; }
    public DateTime fecha_registro { get; private set; }
    public DateTime? fecha_salida { get; private set; }
    public DateTime? fecha_modificacion { get; private set; }
    public km_Salida km_Salida { get; private set; }
    public km_retorno km_Retorno { get; private set; }
    public telefono telefono { get; private set; }
    public usuario usuario { get; private set; }
    public cant_usuario cant_Usuario { get; private set; }
    public id_usuario_ini id_Usuario_Ini { get; private set; }
    public id_usuario_sec id_Usuario_Sec { get; private set; }
    public fecha_registro_dir fecha_Registro_Dir { get; private set; }
    public id_usuario_dir id_Usuario_Dir { get; private set; }
    public id_usuario_oga id_Usuario_Oga { get; private set; }
    public id_usuario_sup id_Usuario_Sup { get; private set; }
    public veh_inicio veh_Inicio { get; private set; }
    //public conf_og {get; private set;}
    public correo_sec correo_Sec { get; private set; }
    public vusuario vusuario { get; private set; }
    public vcoordinador vcoordinador { get; private set; }
    public estado estad { get; private set; }
}


 
