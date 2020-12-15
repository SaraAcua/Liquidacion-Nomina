using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Liquidacion
    {
        public string IdSede { get; set; }
        public string IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public int horastrabajadas { get; set; }
        public string periodo { get; set; }
        public string Vigencia { get; set; }
       public int Valor { get; set; }
        public Liquidacion()
        {

        }
    }
}
