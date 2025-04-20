using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{

    public class Contacto
    {
        // Campo estático para llevar un conteo de los IDs generados.
        private static int contadorId = 0;

        // Propiedad de solo lectura para el ID de cada contacto.
        public int Id { get; private set; }

        // Propiedades públicas para almacenar información del contacto.
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }


        protected Contacto(string nombre, string apellido, string telefono, string correo)
        {
            // Al crear un nuevo contacto, se incrementa el contador y se asigna un nuevo ID automáticamente.
            Id = ++contadorId;


            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
        }
    }
}

