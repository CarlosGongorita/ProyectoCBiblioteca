using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCBiblioteca
{
    class Editorial
    {
        public int Id { get; }
        public string Descripcion { get; }
        public Editorial(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
