using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Dentista : Contacto
    {

        public int Id { get; private set; }
        public string Apellido { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        public string PuestoLaboral { get; private set; }


        public Dentista(int id, string nombre, string apellido, string telefono, string correo, DateTime fechaNacimiento, string puestoLaboral)
            : base(nombre, telefono, correo)
        {
            Id = id;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            PuestoLaboral = puestoLaboral;
        }


        public int Edad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear)
                edad--;
            return edad;
        }


        public override void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Correo: {Correo}");
            Console.WriteLine($"Edad: {Edad()}");
            Console.WriteLine($"Puesto Laboral: {PuestoLaboral}");
            Console.WriteLine("------------------------");
        }


        public override string ToString()
        {
            return $"{Nombre} {Apellido}, Tel: {Telefono}, Edad: {Edad()}, Puesto: {PuestoLaboral}";
        }
    }
}
