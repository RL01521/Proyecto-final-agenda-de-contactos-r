using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Telefono
    {

        private static int contadorId = 1;
        private int id;
        private string numero;
        private string tipo; // "Casa", "Trabajo", etc.


        public int Id => id; // Solo lectura
        public string Numero
        {
            get => numero;
            set => numero = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("El número no puede estar vacío.");
        }
        public string Tipo
        {
            get => tipo;
            set => tipo = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("El tipo no puede estar vacío.");
        }


        public int ContactoId { get; set; }

        public Telefono(string numero, string tipo, int contactoId)
        {
            id = contadorId++;
            Numero = numero;
            Tipo = tipo;
            ContactoId = contactoId;


        }
    }
}

