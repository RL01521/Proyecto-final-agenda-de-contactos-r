using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Empleado : Contacto
    {

        public int Id { get; private set; }
        public string Cargo { get; private set; }
        public decimal Salario { get; private set; }


        public Empleado(int id, string nombre, string telefono, string correo, string cargo, decimal salario)
            : base(nombre, telefono, correo)
        {
            Id = id;
            Cargo = cargo;
            Salario = salario;
        }


        public override void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Correo: {Correo}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salario: {Salario:C}");
            Console.WriteLine("------------------------");
        }
    }


    public class EmpleadoGerente
    {
        private List<Empleado> empleados = new List<Empleado>();


        public void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }


        public void MostrarEmpleados()
        {
            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados.");
                return;
            }

            Console.WriteLine("Lista de empleados:");
            foreach (var empleado in empleados)
            {
                empleado.MostrarInformacion();
            }

        }
    }
}
