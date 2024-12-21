using proyecto_1_evaluacion.Ejercicio3;
using System.Text;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int dialogoActual = 1; // Controla qué diálogo está activo

        public MainWindow()
        {
            InitializeComponent();
            MostrarDialogo(dialogoActual); // Mostrar el primer diálogo al iniciar
            this.PreviewMouseWheel += MainWindow_PreviewMouseWheel;
        }

        private void MostrarDialogo(int numeroDialogo)
        {
            // Ocultar todos los diálogos
            dialogo1.Visibility = Visibility.Hidden;
            dialogo2.Visibility = Visibility.Hidden;
            dialogo3.Visibility = Visibility.Hidden;

            // Mostrar el diálogo correspondiente
            switch (numeroDialogo)
            {
                case 1:
                    dialogo1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    dialogo2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    dialogo3.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (dialogoActual < 3)
            {
                dialogoActual++; // Pasar al siguiente diálogo
                MostrarDialogo(dialogoActual); // Actualizar visibilidad
            }
            else
            {
                // Ocultar diálogos y permitir la interacción normal
                dialogo1.Visibility = Visibility.Hidden;
                dialogo2.Visibility = Visibility.Hidden;
                dialogo3.Visibility = Visibility.Hidden;
                dialogoActual = 0; // Desactivar la secuencia de diálogos
            }
        }
        private void Checkpoint1_Click(object sender, RoutedEventArgs e)
        {
            // Crear una nueva instancia de la ventana
            Ejercicio1 newWindow = new Ejercicio1(this);

            // Mostrar la nueva ventana
            this.IsEnabled = false;
            // Suscribirse al evento Closed del checkpoint
            newWindow.Closed += (s, args) => this.IsEnabled = true;

            newWindow.Show();
        }

        private void Checkpoint2_Click(object sender, RoutedEventArgs e)
        {
            if (Puntuacion.Pregunta1 == 1 && Puntuacion.Pregunta2 == 1)
            {
                Ejercicion2 newWindow = new Ejercicion2(this);

                // Mostrar la nueva ventana
                this.IsEnabled = false;
                // Suscribirse al evento Closed del checkpoint
                newWindow.Closed += (s, args) => this.IsEnabled = true;

                newWindow.Show();
            }
        }
        private void Checkpoint3_Click(object sender, RoutedEventArgs e)
        {
            if (Puntuacion.Pregunta3 == 1 && Puntuacion.Pregunta4 == 1)
            {
                Ejercicio3.Ejercicio3 newWindow = new Ejercicio3.Ejercicio3(this);

                // Mostrar la nueva ventana
                this.IsEnabled = false;
                // Suscribirse al evento Closed del checkpoint
                newWindow.Closed += (s, args) => this.IsEnabled = true;

                newWindow.Show();
            }
        }
        private void Checkpoint4_Click(object sender, RoutedEventArgs e)
        {
            if (Puntuacion.Pregunta5 == 1 && Puntuacion.Pregunta6 == 1)
            {
                Ejercicio4.Ejercicio4 newWindow = new Ejercicio4.Ejercicio4(this);

                // Mostrar la nueva ventana
                this.IsEnabled = false;
                // Suscribirse al evento Closed del checkpoint
                newWindow.Closed += (s, args) => this.IsEnabled = true;

                newWindow.Show();
            }
        }

        private void Checkpoint5_Click(object sender, RoutedEventArgs e)
        {
            if (Puntuacion.Pregunta7 == 1 && Puntuacion.Pregunta8 == 1)
            {
                Ejercicio5.Ejercicio5 newWindow = new Ejercicio5.Ejercicio5(this);

                // Mostrar la nueva ventana
                this.IsEnabled = false;
                // Suscribirse al evento Closed del checkpoint
                newWindow.Closed += (s, args) => this.IsEnabled = true;

                newWindow.Show();
            }
        }

        private void MainWindow_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            // Verifica que el scrollViewer no sea nulo
            if (scrollViewer != null)
            {
                // Desplazamiento horizontal del ScrollViewer
                scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset - e.Delta);

                // Evita que otros controles manejen este evento
                e.Handled = true;
            }
        }
        
        public void ActualizarProgreso()
        {
            this.IsEnabled = true;
            // Actualiza el texto para mostrar el progreso actual
            TextBlockProgreso.Text = $"{Puntuacion.Puntos}/10";
            if (Puntuacion.Puntos==10)
            {
                PantallaCelebracion.Navigate(new Pantalla_celebracion());
            }
        }
    }
}