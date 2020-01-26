using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empresa : IEquatable<Empresa>
    {
        public Empresa()
        {

        }

        public Empresa(string nombre)
        {
            Nombre = nombre;
        }

        public Empresa(string nombre, string logo, string contrasenia)
        {
            Nombre = nombre;
            Logo = logo;
            Contrasenia = contrasenia;
        }

        public string Nombre { get; set; }
        public string Logo { get; set; }
        public string Contrasenia { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Empresa);
        }

        public bool Equals(Empresa other)
        {
            return other != null &&
                   Nombre == other.Nombre;
        }

        public override int GetHashCode()
        {
            return 289764928 + EqualityComparer<string>.Default.GetHashCode(Nombre);
        }
    }
}
