﻿using registroDestalle.BLL;
using registroDestalle.Entidades;
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

namespace registroDestalle.UI.Registros
{
    /// <summary>
    /// Interaction logic for rUsuarios.xaml
    /// </summary>
    public partial class rUsuarios : Window
    {
        public class DateFormat : System.Windows.Data.IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                if (value == null) return null;

                return ((DateTime)value).ToString("dd/MM/yyyy");
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
        private Usuarios usuario = new Usuarios();
        public rUsuarios()
        {
            InitializeComponent();

            this.DataContext = usuario;
        }

        private void Limpiar()
        {
            this.usuario = new Usuarios();
            this.DataContext = usuario;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (PermisoIdTextBox.Text.Length == 0)
            {
                esValido = false;
                //AliasTextBox.Focus();
                MessageBox.Show("No puede dejar campos vacios. Ingrese el Alias.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (NombreTextBox.Text.Length == 0)
            {
                esValido = false;
                //NombresTextBox.Focus();
                MessageBox.Show("No puede dejar campos vacios. Ingrese el nombre completo", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return esValido;
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var usuarios = UsuariosBLL.Buscar(Utilidades.ToInt(IdTextBox.Text));
            if (usuarios != null)
                this.usuario = usuarios;
            else
            {
                this.usuario = new Usuarios();
                MessageBox.Show("No se ha Encontrado", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            this.DataContext = this.usuario;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = UsuariosBLL.Guardar(usuario);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion exitosa!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsuariosBLL.Eliminar(Utilidades.ToInt(IdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
