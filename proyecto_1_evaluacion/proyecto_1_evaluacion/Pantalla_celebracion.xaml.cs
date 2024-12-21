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

namespace proyecto_1_evaluacion
{
    public partial class Pantalla_celebracion : Page
    {
        private int clickCount = 0; // Contador de clics

        public Pantalla_celebracion()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Marcar el evento como manejado para evitar que se propague
            e.Handled = true;

            clickCount++;

            if (clickCount == 1)
            {
                // Mostrar la imagen del explorador
                CelebrationImage.Visibility = Visibility.Hidden;
                ExplorerImage.Visibility = Visibility.Visible;
            }
            else if (clickCount == 2)
            {
                // Cerrar la aplicación
                Application.Current.Shutdown();
            }
        }
    }
}
