using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ProyectoCBiblioteca
{
    class Program
    {
        private static Biblioteca biblioteca;
        static void Main(string[] args)
        {
            biblioteca = new Biblioteca();
            int option = 0;
            do
            {
                Clear();
                WriteLine("-----------------------------------------");
                WriteLine("|               BIBLIOTECA              |");
                WriteLine("|            -Menú principal-           |");
                WriteLine("-----------------------------------------\n");
                WriteLine("1. Usuarios");
                WriteLine("2. Inventario");
                WriteLine("3. Préstamos");
                WriteLine("0. Salir");
                Write("\nElige una opción: ");
                option = Convert.ToInt32(ReadLine());
                switch (option)
                {
                    case 1:
                        MenuUsuarios();
                        break;
                    case 2:
                        MenuInvetario();
                        break;
                    case 3:
                        WriteLine("Función no implementada");
                        ReadKey();
                        break;
                    case 0:
                        break;
                    default:
                        WriteLine("\n¡Opción NO válida!");
                        ReadKey();
                        break;
                }
            }
            while (option != 0);
        }
        private static void MenuUsuarios()
        {
            int option = 0;
            do
            {
                Clear();
                WriteLine("-----------------------------------------");
                WriteLine("|               BIBLIOTECA              |");
                WriteLine("|               -Usuarios-              |");
                WriteLine("-----------------------------------------\n");
                WriteLine("1. Mostrar");
                WriteLine("2. Agregar");
                WriteLine("3. Eliminar");
                WriteLine("0. Volver");
                Write("\nElige una opción: ");
                option = Convert.ToInt32(ReadLine());
                switch (option)
                {
                    case 1:
                        SubMenuMostrar();
                        break;
                    case 2:
                        AgregaNuevoUsuario();
                        break;
                    case 3:
                        EliminarUsuario();
                        ReadKey();
                        break;
                    case 0:
                        break;
                    default:
                        WriteLine("\n¡Opción NO válida!");
                        ReadKey();
                        break;
                }
            }
            while (option != 0);
        }
        private static void SubMenuMostrar()
        {
            char option;
            Clear();
            WriteLine("-----------------------------------------");
            WriteLine("|          - Mostrar Usuarios-           |");
            WriteLine("-----------------------------------------\n");
            WriteLine("Por: ");
            WriteLine("a) Apellido");
            WriteLine("b) Nombre");
            WriteLine("c) Id");
            Write("\nElige una opción: ");
            option = ReadLine().ToLower().Trim()[0];
            switch (option)
            {
                case 'a':
                    UsuariosPorApellido();
                    break;
                case 'b':
                    UsuariosPorNombre();
                    break;
                case 'c':
                    UsuariosPorId();
                    break;
                default:
                    WriteLine("\n¡Opción NO válida!");
                    break;
            }
        }
        private static void UsuariosPorApellido()
        {
            Clear();
            WriteLine("-----------------------------------------");
            WriteLine("|          - Mostrar Usuarios-          |");
            WriteLine("-----------------------------------------\n");
            var usuarios = biblioteca.GetUsuariosPorApellido();
            usuarios.ForEach(u => WriteLine($"{u.Apellido} {u.Nombre} (Id: {u.Id})"));
            ReadKey();
        }
        private static void UsuariosPorNombre()
        {
            Clear();
            WriteLine("-----------------------------------------");
            WriteLine("|          - Mostrar Usuarios-          |");
            WriteLine("-----------------------------------------\n");
            var usuarios = biblioteca.GetUsuariosPorNombre();
            usuarios.ForEach(u => WriteLine($"{u.Nombre} {u.Apellido} (Id: {u.Id})"));
            ReadKey();
        }
        private static void UsuariosPorId()
        {
            Clear();
            WriteLine("-----------------------------------------");
            WriteLine("|          - Mostrar Usuarios-          |");
            WriteLine("-----------------------------------------\n");
            var usuarios = biblioteca.GetUsuariosPorId();
            usuarios.ForEach(u => WriteLine($"{u.Id} / {u.Nombre} {u.Apellido}"));
            ReadKey();
        }
        private static void AgregaNuevoUsuario()
        {
            Clear();
            WriteLine("-----------------------------------------");
            WriteLine("|      - Agregar Nuevo Usuario-         |");
            WriteLine("-----------------------------------------\n");
            int NewIdUsuario = biblioteca.NewIdUsuario();
            WriteLine($"El nuevo Id generado es: {NewIdUsuario}");
            WriteLine("Por favor llena los siguientes datos: ");
            Write("Nombre: ");
            string nombre = ReadLine();
            Write("Apellido: ");
            string apellido = ReadLine();
            biblioteca.CreaNuevoUsuario(NewIdUsuario, nombre, apellido);
            ReadKey();

        }
        private static void EliminarUsuario()
        {
            throw new NotImplementedException();
        }
        private static void MenuInvetario()
        {
            tint option = 0;
            do
            {
                Clear();
                WriteLine("-----------------------------------------");
                WriteLine("|               BIBLIOTECA              |");
                WriteLine("|              -Inventario-              |");
                WriteLine("-----------------------------------------\n");
                WriteLine("1. Alta");
                WriteLine("2. Arribo de copias");
                WriteLine("3. Remover copias");
                WriteLine("4. Baja");
                WriteLine("0. Volver");
                Write("\nElige una opción: ");
                option = Convert.ToInt32(ReadLine());
                switch (option)
                {
                    case 1:
                        AltaLibro();
                        break;
                    case 2:
                    case 3:
                    case 4:
                        WriteLine("Funcion no implementada");
                        ReadKey();
                        break;
                    case 0:
                        break;
                    default:
                        WriteLine("\n¡Opción NO válida!");
                        ReadKey();
                        break;
                }
            }
            while (option != 0);
        }
        private static void AltaLibro()
        {
            Clear();
            WriteLine("-----------------------------------------");
            WriteLine("|       - Agregar Nuevo Libro-           |");
            WriteLine("-----------------------------------------\n");
            WriteLine("(La clave del libro debe contar con )")
            Write("Clave de paciente: ");

        }
    }
}
