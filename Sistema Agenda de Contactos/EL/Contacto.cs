using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public abstract class Contacto
    {
        private string _nombre;
        private string _telefono;
        private string _correo;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }

        public Contacto(string nombre, string telefono, string correo)
        {
            _nombre = nombre;
            _telefono = telefono;
            _correo = correo;
        }

        public abstract void MostrarInformacion();
    }
}

