using System.Windows;
using System.Windows.Controls;

namespace proyecto_1_evaluacion
{
    public partial class Ejercicio1_Pregunta2 : Page
    {
        private readonly Ejercicio1 _parentWindow;

        public Ejercicio1_Pregunta2(Ejercicio1 parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
        }

        private void ConfirmarRespuesta_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el texto ingresado en el TextBox
            string respuesta = RespuestaTextBox.Text.Trim();

            // Verificar si la respuesta es correcta
            if (respuesta.Equals("wood", StringComparison.OrdinalIgnoreCase))
            {
                Puntuacion.Pregunta2 = 1;
                RespuestaCorrecta.Visibility = Visibility.Visible;
            }
            else
            {
                Puntuacion.Pregunta2 = 0;
                RespuestaIncorrecta.Visibility = Visibility.Visible;
            }
            gridBloqueo.Visibility = Visibility.Visible;
        }
        private void GridBloqueo_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Ocultar la capa de bloqueo y permitir la interacción normal
            gridBloqueo.Visibility = Visibility.Collapsed;
            _parentWindow.Pregunta2.Visibility = Visibility.Collapsed;
            _parentWindow.PantallaFinal();
        }
    }
}
