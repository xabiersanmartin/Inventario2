using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoProducto
    {
        public TipoProducto()
        {
        }

        public TipoProducto(int idTipoProducto)
        {
            IdTipoProducto = idTipoProducto;
        }

        public TipoProducto(int idTipoProducto, string descripcion)
        {
            IdTipoProducto = idTipoProducto;
            Descripcion = descripcion;
        }

        public int IdTipoProducto { get; set; }
        public string Descripcion { get; set; }
    }
}
