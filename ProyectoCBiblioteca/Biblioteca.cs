using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCBiblioteca
{
    class Biblioteca
    {
        private List<Editorial> editoriales;
        private List<Libro> libros;
        private List<Usuario> usuarios;
        private List<Prestamo> prestamos;
        public Biblioteca()
        {
            editoriales = EasyFile<Editorial>.LoadDataFromFile("editoriales.txt",
                t => new Editorial(Convert.ToInt32(t[0]), t[1]));
            libros = EasyFile<Libro>.LoadDataFromFile("libros.txt",
                t => new Libro(Convert.ToInt32(t[0]), Convert.ToInt32(t[1]), Convert.ToInt32(t[2]), t[3], t[4], Convert.ToInt32(t[5]), Convert.ToInt32(t[6]), Convert.ToInt32(t[7])));
            usuarios = EasyFile<Usuario>.LoadDataFromFile("usuarios.txt",
                t => new Usuario(Convert.ToInt32(t[0]), t[1], t[2]));
            prestamos = EasyFile<Prestamo>.LoadDataFromFile("prestamos.txt",
                t => new Prestamo(Convert.ToInt32(t[0]), Convert.ToInt32(t[1])));
        }
        public List<Usuario> GetUsuariosPorApellido()
        {
            var usuarios = new List<Usuario>();
            usuarios = EasyFile<Usuario>.LoadDataFromFile("usuarios.txt",
              t => new Usuario(Convert.ToInt32(t[0]), t[1], t[2]));
            usuarios.Sort((x, y) => x.Apellido.CompareTo(y.Apellido));
            return usuarios;
        }
        public List<Usuario> GetUsuariosPorNombre()
        {
            var usuarios = new List<Usuario>();
            usuarios = EasyFile<Usuario>.LoadDataFromFile("usuarios.txt",
              t => new Usuario(Convert.ToInt32(t[0]), t[1], t[2]));
            usuarios.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));
            return usuarios;
        }
        public List<Usuario> GetUsuariosPorId()
        {
            var usuarios = new List<Usuario>();
            usuarios = EasyFile<Usuario>.LoadDataFromFile("usuarios.txt",
              t => new Usuario(Convert.ToInt32(t[0]), t[1], t[2]));
            usuarios.Sort((x, y) => x.Id.CompareTo(y.Id));
            return usuarios;
        }
        public int NewIdUsuario()
        {
            var usuarios = new List<Usuario>();
            usuarios = EasyFile<Usuario>.LoadDataFromFile("usuarios.txt",
              t => new Usuario(Convert.ToInt32(t[0]), t[1], t[2]));
            Usuario usuario = usuarios.Last();
            int NewIdUsuario = usuario.Id + 1;
            return NewIdUsuario;

        }
        public void CreaNuevoUsuario(int id, string nombre, string apellido)
        {
            usuarios.Add(new Usuario(id, nombre, apellido));
            EasyFile<Usuario>.SaveDataToFile("usuarios.txt", new string[] { "Id", "Nombre", "Apellido" },usuarios);
        }
    }
}
