using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class GestorContactos
    {
        private List<Contacto> contactos;

        public GestorContactos()
        {
            contactos = new List<Contacto>();
        }

        public void AgregarContacto(Contacto contacto)
        {
            if (contacto == null)
                throw new ArgumentNullException(nameof(contacto), "El contacto no puede ser nulo.");

            contactos.Add(contacto);
            Console.WriteLine($"Contacto {contacto.Nombre} agregado exitosamente.");
        }

        public bool EliminarContacto(string nombre)
        {
            var contacto = BuscarContactoPorNombre(nombre);

            if (contacto != null)
            {
                contactos.Remove(contacto);
                Console.WriteLine($"Contacto {nombre} eliminado exitosamente.");
                return true;
            }

            Console.WriteLine($"No se encontró un contacto con el nombre {nombre}.");
            return false;
        }

        public Contacto BuscarContactoPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser nulo o estar vacío.", nameof(nombre));

            return contactos.FirstOrDefault(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
    }
}

