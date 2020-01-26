using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public Categoria()
        {
        }

        public Categoria(int idCategoria)
        {
            IdCategoria = idCategoria;
        }

        public Categoria(int idCategoria, string descripcion)
        {
            IdCategoria = idCategoria;
            Descripcion = descripcion;
        }

        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
    }
}
