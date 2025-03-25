using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class GestorCitas
    {
        private List<Cita> citas = new List<Cita>();


        public void AgregarCita(Cita cita)
        {
            citas.Add(cita);
        }


        public void MostrarCitas()
        {
            if (citas.Count == 0)
            {
                Console.WriteLine("No hay citas registradas.");
                return;
            }

            Console.WriteLine("Lista de citas:");
            foreach (var cita in citas)
            {
                cita.MostrarCita();
                Console.WriteLine("------------------------");
            }
        }

    }
}
