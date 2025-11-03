using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para WindowCliente.xaml
    /// </summary>
    public partial class WindowCliente : Window
    {
        private NCliente nCliente = new NCliente();

        private ECliente clienteSeleccionado = null;
        public WindowCliente()
        {
            InitializeComponent();
            MostrarClientes(nCliente.ListarTodosLosClientes());
        }

        private void MostrarClientes(List<ECliente> clientes)
        {
            dgClientes.ItemsSource = null;
            dgClientes.ItemsSource = clientes;
        }

        private void LimpiarCampos()
        {
            tbDNI.Clear();
            tbNombre.Clear();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if(tbDNI.Text == "" || tbNombre.Text == "")
            {
                MessageBox.Show("Debe rellenar todos los campos", "Aviso", MessageBoxButton.OK);
                return;
            }

            ECliente cliente = new ECliente()
            { 
                DNI = tbDNI.Text,
                Nombre = tbNombre.Text,
                Categoría = cbCategoria.Text,
            };

            bool registrado = nCliente.Registrar(cliente);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro DNI");
                return;
            }
            MostrarClientes(nCliente.ListarTodosLosClientes());
            LimpiarCampos();
            tbDNI.Focus();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void dgClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            clienteSeleccionado = dgClientes.SelectedItem as ECliente;
        }
    }
}
