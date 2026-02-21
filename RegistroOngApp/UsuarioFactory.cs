using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroOngApp
{
    public abstract class Usuario
    {
        public string Nombre { get; set; }
        public abstract string GetRol();
    }

    public class Voluntario : Usuario
    {
        public override string GetRol()
        {
            return "Voluntario";
        }
    }

    public class Coordinador : Usuario
    {
        public override string GetRol()
        {
            return "Coordinador";
        }
    }

    public static class CreadorUsuario
    {
        public static Usuario Crear(string tipo, string nombre)
        {
            Usuario nuevoUsuario;

            switch (tipo)
            {
                case "Voluntario":
                    nuevoUsuario = new Voluntario();
                    break;

                case "Coordinador":
                    nuevoUsuario = new Coordinador();
                    break;

                default:
                    throw new ArgumentException("Tipo no válido");
            }

            nuevoUsuario.Nombre = nombre;
            return nuevoUsuario;
        }
    }
}
