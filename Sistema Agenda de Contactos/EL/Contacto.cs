using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public abstract class Contacto
    {
        
        private static int contadorId = 0;

        public int Id { get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        protected Contacto(string nombre, string apellido, string telefono, string correo)
        {
            Id = ++contadorId; 
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
        }
    }

}

