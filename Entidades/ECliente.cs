using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECliente
    {
        public ECliente() { }

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Categoría { get; set; }
        public double Crédito { get; set; }
    }
}
