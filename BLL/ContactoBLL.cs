using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{

    public class ContactoBLL
    {
        public void Insertar(Contacto contacto)
        {
            using (var context = new ClinicaDentalContext()) // Se crea un contexto de base de datos.
            {
                context.Contactos.Add(contacto);
                context.SaveChanges();
            }
        }

        // Método para actualizar un contacto existente en la base de datos.
        public void Actualizar(Contacto contacto)
        {
            using (var context = new ClinicaDentalContext())
            {
                var existente = context.Contactos.Find(contacto.Id); // Se busca el contacto por su ID.
                if (existente != null) // Si el contacto existe,
                {
                    context.Entry(existente).CurrentValues.SetValues(contacto); // Se actualizan sus valores.
                    context.SaveChanges();
                }
            }
        }

        // Método para eliminar un contacto de la base de datos según su ID.
        public void Eliminar(int id)
        {
            using (var context = new ClinicaDentalContext())
            {
                var contacto = context.Contactos.Find(id);
                if (contacto != null) // Si existe,
                {
                    context.Contactos.Remove(contacto); // Se elimina.
                    context.SaveChanges();
                }
            }
        }

        // Método para obtener un contacto específico por su ID.
        public Contacto ObtenerPorId(int id)
        {
            using (var context = new ClinicaDentalContext())
            {
                return context.Contactos.Find(id); // Se devuelve el contacto encontrado.
            }
        }

        // Método para obtener una lista de todos los contactos.
        public List<Contacto> ObtenerTodos()
        {
            using (var context = new ClinicaDentalContext())
            {
                return context.Contactos.ToList(); // Se obtiene la lista completa de contactos.
            }
        }

        // Método para obtener solo los contactos que son pacientes.
        public List<Paciente> ObtenerTodosPacientes()
        {
            using (var context = new ClinicaDentalContext())
            {
                return context.Contactos.OfType<Paciente>().ToList();
                // Se filtran los contactos que son de tipo Paciente y se devuelven.
            }
        }

        // Método para obtener solo los contactos que son empleados.
        public List<Empleado> ObtenerTodosEmpleados()
        {
            using (var context = new ClinicaDentalContext())
            {
                return context.Contactos.OfType<Empleado>().ToList();
                // Se filtran los contactos que son de tipo Empleado y se devuelven.
            }
        }
    }
}