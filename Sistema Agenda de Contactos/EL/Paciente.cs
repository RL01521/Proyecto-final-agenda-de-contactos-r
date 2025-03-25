using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
        public class Paciente : Contacto
        {

            public int Id { get; private set; }
            public string Apellido { get; private set; }
            public DateTime FechaNacimiento { get; private set; }


            public Paciente(int id, string nombre, string apellido, string telefono, string correo, DateTime fechaNacimiento)
                : base(nombre, telefono, correo)
            {
                Id = id;
                Apellido = apellido;
                FechaNacimiento = fechaNacimiento;
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
                Console.WriteLine($"{Nombre} {Apellido}, Tel: {Telefono}, Edad: {Edad()}");
            }


            public override string ToString()
            {
                return $"{Nombre} {Apellido}, Tel: {Telefono}, Edad: {Edad()}";
            }
        }


    }

