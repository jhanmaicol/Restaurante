using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RestauranteStore.Entities.Entities;

namespace RestauranteStore.Entities.IRepositories
{
   public interface IUnityOfWork : IDisposable
    {

        IAlmacenRepository Almacenes { get; }
        ICancelarReservaRepository CancelarReservas { get; }
        ICartaRepository Cartas { get; }
        IClienteRepository Clientes { get; }
        IEmpleadoRepository Empleados { get; }
        IEspecialidadDiaRepository EspecialidadDias { get; }
        IEstadoPedidoRepository EstadoPedidos { get; }
        IIngredienteRepository Ingredientes { get; }
        IMesaRepository Mesas { get; }
        IPedidoRepository Pedidos { get; }
        IPersonaRepository Personas { get; }
        IPlatoComidaRepository PlatoComidas { get; }
        IProveedorRepository Proveedors { get; }
        IReservaRepository Reservas { get;  }
        ITipoEmpleadoRepository TipoEmpleados { get; }
        ITurnoRepository Turnos { get; }

        int SaveChanges();

        void StateModedified(object entity);

    }
}
