using proyecto_1_evaluacion.Ejercicio2;
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

namespace proyecto_1_evaluacion.Ejercicio3
{
    /// <summary>
    /// Lógica de interacción para Ejercicio3.xaml
    /// </summary>
    public partial class Ejercicio3 : Window
    {
        private readonly MainWindow _parentWindow;
        public Ejercicio3(MainWindow parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
            // Cargar la primera pregunta en el Frame de Pregunta1
            Pregunta1.Content = new Ejercicio3_Pregunta1(this);
        }

        // Metodo para cambiar al frame de la siguiente pregunta
        public void IrASiguientePregunta()
        {
            // Ocultar el frame de Pregunta1
            Pregunta1.Visibility = Visibility.Collapsed;

            // Mostrar el frame de Pregunta2
            Pregunta2.Visibility = Visibility.Visible;
            Pregunta2.Content = new Ejercicio3_Pregunta2(this);
        }

        //Mostrar pantalla final de ejercicio.
        public void PantallaFinal()
        {
            Puntuacion.CalcularPuntos();
            gridPantallaPuntuacion.Visibility = Visibility.Visible;
            textBlockPuntuacion.Text = Puntuacion.Puntos.ToString();
        }

        public void VolverAPantallaPrincipal_Click(object sender, RoutedEventArgs e)
        {
            if (Puntuacion.Pregunta5 == 1 && Puntuacion.Pregunta6 == 1)
            {
                _parentWindow.BotonEjercicio4.Style = (Style)this.FindResource("CircularTransparentButtonStyle");
            }
            _parentWindow.ActualizarProgreso();
            this.Close();
        }
    }
}
