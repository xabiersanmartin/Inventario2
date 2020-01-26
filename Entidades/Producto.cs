using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public Producto()
        {
        }

        public Producto(int idProducto, TipoProducto tipoProducto, Categoria cate, Medidas medida)
        {
            IdProducto = idProducto;
            TipoProducto = tipoProducto;
            Categoria = cate;
            Medida = medida;
        }

        public Producto(int idProducto, string nombre, float precio, int stock,TipoProducto tipoProducto, Categoria cate, Medidas medida)
        {
            IdProducto = idProducto;
            Descripcion = nombre;
            Precio = precio;
            Stock = stock;
            TipoProducto = tipoProducto;
            Categoria = cate;
            Medida = medida;
        }

        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
        public TipoProducto TipoProducto { get; set; }
        public Categoria Categoria { get; set; }
        public Medidas Medida { get; set; }

        public override string ToString()
        {
            return  "Tipo Producto: " + TipoProducto + ", Categoria: "+ Categoria.Descripcion + ",  Producto:" + Descripcion + ", Medidas:" + Medida.Descripcion + ", Precio:" + Precio.ToString() + ", Stock: " + Stock.ToString();
        }
    }
}
