using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Cita
    {

        public Paciente Paciente { get; set; }
        public Dentista Dentista { get; set; }
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; }


        public Cita(Paciente paciente, Dentista dentista, DateTime fechaHora, string motivo)
        {
            Paciente = paciente;
            Dentista = dentista;
            FechaHora = fechaHora;
            Motivo = motivo;
        }


        public void MostrarCita()
        {
            Console.WriteLine("------ Detalle de la Cita ------");
            Console.WriteLine($"Paciente: {Paciente.Nombre} {Paciente.Apellido}");
            Console.WriteLine($"Dentista: {Dentista.Nombre} {Dentista.Apellido}");
            Console.WriteLine($"Fecha y hora: {FechaHora}");
            Console.WriteLine($"Motivo: {Motivo}");
        }
    }
}
