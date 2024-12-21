using System.Windows;
using System.Windows.Controls;

namespace proyecto_1_evaluacion
{
    public partial class Ejercicio1 : Window
    {
        private readonly MainWindow _parentWindow;
        public Ejercicio1(MainWindow parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
            // Cargar la primera pregunta en el Frame de Pregunta1
            Pregunta1.Content = new Ejercicio1_Pregunta1(this);
        }

        // Metodo para cambiar al frame de la siguiente pregunta
        public void IrASiguientePregunta()
        {
            // Ocultar el frame de Pregunta1
            Pregunta1.Visibility = Visibility.Collapsed;

            // Mostrar el frame de Pregunta2
            Pregunta2.Visibility = Visibility.Visible;
            Pregunta2.Content = new Ejercicio1_Pregunta2(this);
        }

        //Mostrar pantalla final de ejercicio.
        public void PantallaFinal()
        {
            Puntuacion.CalcularPuntos();
            gridPantallaPuntuacion.Visibility = Visibility.Visible;
            textBlockPuntuacion.Text = Puntuacion.Puntos.ToString();
            if (Puntuacion.Pregunta1 == 1 && Puntuacion.Pregunta2 == 1)
            {
                imagenSuperado.Visibility = Visibility.Visible;
            }
            else
            {
                imagenFallido.Visibility = Visibility.Visible;
            }
            gridBloqueo.Visibility = Visibility.Visible;
        }
        private void GridBloqueo_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Ocultar la capa de bloqueo y permitir la interacción normal
            gridBloqueo.Visibility = Visibility.Collapsed;
        }

        public void VolverAPantallaPrincipal_Click(object sender, RoutedEventArgs e)
        {
            if (Puntuacion.Pregunta1==1 && Puntuacion.Pregunta2 == 1)
            {
                _parentWindow.BotonEjercicio2.Style = (Style)this.FindResource("CircularTransparentButtonStyle");
            }
            _parentWindow.ActualizarProgreso();
            this.Close();
        }
    }
}
