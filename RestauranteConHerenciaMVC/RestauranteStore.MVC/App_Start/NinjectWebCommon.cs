[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(RestauranteStore.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(RestauranteStore.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace RestauranteStore.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using RestauranteStore.Persistence.Repositories;
    using RestauranteStore.Entities.IRepositories;
    using RestauranteStore.Persistence;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //UnityOfWork
            kernel.Bind<IUnityOfWork>().To<UnityOfWork>();

            //RestauranteStoreDbContext
            kernel.Bind<RestauranteStoreDbContext>().To<RestauranteStoreDbContext>();

            //AlmacenRepository
            kernel.Bind<IAlmacenRepository>().To<AlmacenRepository>();

            //CancelarRepository
            kernel.Bind<ICancelarReservaRepository>().To<CancelarReservaRepository>();

            //CartaRepository
            kernel.Bind<ICartaRepository>().To<CartaRepository>();

            //EspecialidadDiaRepository
            kernel.Bind<IEspecialidadDiaRepository>().To<EspecialidadDiaRepository>();

            //EstadoPedidoRepository
            kernel.Bind<IEstadoPedidoRepository>().To<EstadoPedidoRepository>();

            //IngedienteRepository
            kernel.Bind<IIngredienteRepository>().To<IngredienteRepository>();

            //MesaRepository
            kernel.Bind<IMesaRepository>().To<MesaRepository>();

            //PedidoRepository
            kernel.Bind<IPedidoRepository>().To<PedidoRepository>();

            //PersonaRepository
            kernel.Bind<IPersonaRepository>().To<PersonaRepository>();

            //PlatoComidaRepository
            kernel.Bind<IPlatoComidaRepository>().To<PlatoComidaRepository>();

            //ProveedorRepository
            kernel.Bind<IProveedorRepository>().To<ProveedorRepository>();

            //ReservaRepository
            kernel.Bind<IReservaRepository>().To<ReservaRepository>();

            //TipoEmpleadoRepository
            kernel.Bind<ITipoEmpleadoRepository>().To<TipoEmpleadoRepository>();

            //TurnoRepository
            kernel.Bind<ITurnoRepository>().To<TurnoRepository>();
            
        }        
    }
}
