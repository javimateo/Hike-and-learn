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

namespace proyecto_1_evaluacion.Ejercicio3
{
    /// <summary>
    /// Lógica de interacción para Ejercicio3_Pregunta5.xaml
    /// </summary>
    public partial class Ejercicio3_Pregunta1 : Page
    {
        private readonly Ejercicio3 _parentWindow;

        public Ejercicio3_Pregunta1(Ejercicio3 parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
        }
        private void FixedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Mostrar el valor del Slider en el TextBlock
            SliderValueText.Text = $"{FixedSlider.Value}";
        }

        private void ConfirmarRespuesta_Click(object sender, RoutedEventArgs e)
        {
            if (FixedSlider.Value == 2)
            {
                Puntuacion.Pregunta5 = 1;
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
