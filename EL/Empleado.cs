using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public enum Cargo
    {
        Dentista,
        Administrativo
    }

    public class Empleado : Contacto
    {


        public Cargo CargoEmpleado { get; set; }
        public DateTime FechaContratacion { get; set; }

        public Empleado(string nombre, string apellido, string telefono, string correo, Cargo cargo, DateTime fechaContratacion)
            : base(nombre, apellido, telefono, correo)
        {
            CargoEmpleado = cargo;
            FechaContratacion = fechaContratacion;
        }
    }
}