using registroDestalle.UI.Consultas;
using registroDestalle.UI.Registros;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace registroDestalle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RolMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rRoles rol = new rRoles();
            rol.Show();
        }

        private void ConsultaRolMenuItem_Click(object sender, RoutedEventArgs e)
        {

            cRoles roles = new cRoles();
            roles.Show();
        }

        private void DetalleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rUsuarios user = new rUsuarios();
            user.Show();
        }

        private void ConsultaDetalleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cUsuarios consulta = new cUsuarios();
            consulta.Show();
        }
    }
}
