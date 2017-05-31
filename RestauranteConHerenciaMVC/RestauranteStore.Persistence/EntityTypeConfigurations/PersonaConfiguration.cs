using RestauranteStore.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteStore.Persistence.EntityTypeConfigurations
{
    public class PersonaConfiguration : EntityTypeConfiguration<Persona>
    {
        public PersonaConfiguration()
        {
            //Table Configurations
            ToTable("Personas");
            HasKey(c => c.PersonaId);
           Property(c => c.NombrePersona).IsRequired();
            //Property(c => c.ApellidoPaterno).IsRequired();
            //Property(c => c.ApellidoMaterno).IsRequired();
            //Property(c => c.FechaNacimiento).IsRequired();
            //Property(c => c.Sexo).IsRequired();
            //Property(c => c.Telefono).IsRequired();
            //Property(c => c.Direccion).IsRequired();

           
             Map<Cliente>(m => m.Requires("Discriminator").HasValue("Cliente"));
             Map<Empleado>(m => m.Requires("Discriminator").HasValue("Empleado"));
            

           

        }

    }
}
