using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCBiblioteca
{
    class Libro
    {
        public int Id { get; }
        public int Copias { get; }
        public int Disponibles { get; }
        public string Titulo { get; }
        public string Autor { get; }
        public int Editoriald { get; }
        public int Edicion { get; }
        public int Año { get; }
        public Libro(int id, int copias, int disponibles, string titulo, string autor, int editoriald, int edicion, int año)
        {
            Id = id;
            Copias = copias;
            Disponibles = disponibles;
            Titulo = titulo;
            Autor = autor;
            Editoriald = editoriald;
            Edicion = edicion;
            Año = año;
        }
    }
}
