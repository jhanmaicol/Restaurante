using RestauranteStore.Entities.Entities;
using RestauranteStore.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteStore.Persistence.Repositories
{
   public class AlmacenRepository : Repository<Almacen>, IAlmacenRepository
    {
        //public AlmacenRepository(RestauranteStoreDbContext context) : base(context)
        //{

        //}
        private readonly RestauranteStoreDbContext _Context;

        private AlmacenRepository()
        {

        }

        public AlmacenRepository(RestauranteStoreDbContext context)
        {
            _Context = context;
        }
    }
}
