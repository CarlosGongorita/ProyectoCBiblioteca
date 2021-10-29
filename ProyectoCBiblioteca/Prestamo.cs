using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCBiblioteca
{
    class Prestamo
    {
        public int UserId { get; }
        public int LibroId { get; }
        public Prestamo(int userId, int libroId)
        {
            UserId = userId;
            LibroId = libroId;
        }

    }
}
