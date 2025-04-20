using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Paciente : Contacto
    {
        public DateTime FechaNacimiento { get; set; }
        public string HistorialClinico { get; set; }

        public Paciente(string nombre, string apellido, string telefono, string correo, DateTime fechaNacimiento, string historialClinico)
            : base(nombre, apellido, telefono, correo)
        {
            FechaNacimiento = fechaNacimiento;
            HistorialClinico = historialClinico;
        }
    }
}