using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCliente
    {
        private DCliente dCliente = new DCliente();

        public bool Registrar(ECliente cliente)
        {
            if (dCliente.Existe(cliente.DNI))
            {
                return false;
            }
            else
            {
                switch (cliente.Categoría)
                {
                    case "Nuevo": cliente.Crédito = 1000; break;
                    case "Ocasional": cliente.Crédito = 2500; break;
                    case "Frecuente": cliente.Crédito = 5000; break;
                }

                dCliente.Registrar(cliente);
                return true;
            }

        }

        public List<ECliente> ListarTodosLosClientes()
        {
            return DCliente.ListarTodosLosClientes();
        }
    }
}
