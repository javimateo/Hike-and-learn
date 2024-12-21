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

namespace proyecto_1_evaluacion.Ejercicio5
{
    /// <summary>
    /// Lógica de interacción para Ejercicio5_Pregunta1.xaml
    /// </summary>
    public partial class Ejercicio5_Pregunta1 : Page
    {
        private readonly Ejercicio5 _parentWindow;

        public Ejercicio5_Pregunta1(Ejercicio5 parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
        }

        private void ConfirmarRespuesta_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el texto ingresado en el TextBox
            string respuesta = RespuestaTextBox.Text.Trim();

            // Verificar si la respuesta es correcta
            if (respuesta.Equals("map", StringComparison.OrdinalIgnoreCase))
            {
                // Respuesta correcta: incrementar puntuacion
                Puntuacion.Pregunta9 = 1;
                RespuestaCorrecta.Visibility = Visibility.Visible;
            }
            else
            {
                Puntuacion.Pregunta9 = 0;
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
