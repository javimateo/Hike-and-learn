using System.Windows;
using System.Windows.Controls;

namespace proyecto_1_evaluacion
{
    public partial class Ejercicio1_Pregunta1 : Page
    {
        private readonly Ejercicio1 _parentWindow;

        public Ejercicio1_Pregunta1(Ejercicio1 parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
        }

        private void ConfirmarRespuesta_Click(object sender, RoutedEventArgs e)
        {
            // Verificar si la respuesta correcta (Beaver) fue seleccionada

            if (Beaver.IsChecked == true)
            {
                Puntuacion.Pregunta1 = 1;
                RespuestaCorrecta.Visibility = Visibility.Visible;
            }
            else
            {
                Puntuacion.Pregunta1 = 0;
                RespuestaIncorrecta.Visibility = Visibility.Visible;
            }
            gridBloqueo.Visibility = Visibility.Visible;
        }
        private void GridBloqueo_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Ocultar la capa de bloqueo y permitir la interacción normal
            gridBloqueo.Visibility = Visibility.Collapsed;
            _parentWindow.IrASiguientePregunta();
        }
    }
}
