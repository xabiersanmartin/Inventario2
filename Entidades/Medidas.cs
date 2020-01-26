using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medidas
    {
        public Medidas()
        {
        }

        public Medidas(int idMedidas)
        {
            IdMedidas = idMedidas;
        }

        public Medidas(int idMedidas, string descripcion)
        {
            IdMedidas = idMedidas;
            Descripcion = descripcion;
        }

        public int IdMedidas { get; set; }
        public string Descripcion { get; set; }
    }
}
