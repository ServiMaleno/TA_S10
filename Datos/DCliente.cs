using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCliente
    {
        private static List<ECliente> clientes = new List<ECliente>();

        public bool Existe(string dni)
        {
            return clientes.Exists(delegate (ECliente c)
            {
                return c.DNI.Equals(dni);
            });
        }

        public void Registrar(ECliente cliente)
        {
            clientes.Add(cliente);
        }

        public static List<ECliente> ListarTodosLosClientes()
        {
            return clientes;
        }

        public void Eliminar(string dni)
        {
            clientes.RemoveAll(delegate (ECliente c)
            {
                return c.DNI.Equals(dni);
            });
        }

        public List<ECliente> OrdenarPorSueldo()
        {
            List<ECliente>clientesOrdenados = new List<ECliente>(clientes);

            clientesOrdenados.Sort(delegate (ECliente e1, ECliente e2)
            {
                return e1.Crédito.CompareTo(e2.Crédito);
            });

            return clientesOrdenados;
        }
    }
}
