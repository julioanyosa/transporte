using Comision.Application.Abstractions.Messaging;
using Comision.Application.Abstractions.Time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Application.Comisiones.CrearComision;
internal sealed class CrearComisionCommandHandler :
ICommandHandler<CrearComisionCommand, Guid>
{
    private readonly IRolRepository _rolRepository;
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly NombreUsuarioService _nombreUsuarioService;

    public CrearComisionCommandHandler(IRolRepository rolRepository, IUsuarioRepository usuarioRepository, IUnitOfWork unitOfWork, IDateTimeProvider dateTimeProvider, NombreUsuarioService nombreUsuarioService)
    {
        _rolRepository = rolRepository;
        _usuarioRepository = usuarioRepository;
        _unitOfWork = unitOfWork;
        _dateTimeProvider = dateTimeProvider;
        _nombreUsuarioService = nombreUsuarioService;
    }

    public async Task<Result<Guid>> Handle(CrearComisionCommand request, CancellationToken cancellationToken)
    {
        var rol = await _rolRepository.GetByNameAsync(request.Rol, cancellationToken);
        if (rol == null)
        {
            return Result.Failure<Guid>(RolErrores.NoEncontrado);
        }

        var usuario = Usuario.Create(
            new ApellidoPaterno(request.ApellidoPaterno),
            new ApellidoMaterno(request.ApellidoMaterno),
            new NombresPersona(request.Nombres),
            Password.Create(request.Password),
            request.FechaNacimiento,
            CorreoElectronico.Create(request.CorreoElectronico).Value,
            new Direccion(
                request.Pais,
                request.Departamento,
                request.Provincia,
                request.Distrito,
                request.Calle
            ),
            _dateTimeProvider.CurrentTime,
            _nombreUsuarioService
        );

        _usuarioRepository.Add(usuario);

        await _unitOfWork.SaveChangeAsync(cancellationToken);
        return usuario.Id;
    }
}