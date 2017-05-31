using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteStore.Entities.Entities
{
    public class Almacen
    {
        public int AlmacenId { get; set; }
        public string Inventario { get; set; }
        public char EstadoAlm { get; set; }

        //relaciones clases
        public List<Proveedor> Proveedores { get; set; }       
        public List<Ingrediente> Ingredientes { get; set; }
        public Almacen()
        {
            Proveedores = new List<Proveedor>();            
            Ingredientes = new List<Ingrediente>();
        }


    }
}
