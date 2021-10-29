using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCBiblioteca
{
    class Usuario
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Apellido { get; }
        public Usuario(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
