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
    /// Lógica de interacción para Ejercicio5_Pregunta2.xaml
    /// </summary>
    public partial class Ejercicio5_Pregunta2 : Page
    {
        private readonly Ejercicio5 _parentWindow;

        public Ejercicio5_Pregunta2(Ejercicio5 parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
        }

        private void ConfirmarRespuesta_Click(object sender, RoutedEventArgs e)
        {
            // Verificar si la respuesta es correcta
            // Comprobar si las opciones seleccionadas son correctas
            bool opcion1Correcta = CheckBoxTrees.IsChecked == true; // Primera opción debe ser falsa
            bool opcion2Correcta = CheckBoxSnow.IsChecked == false;  // Segunda opción debe ser verdadera
            bool opcion3Correcta = CheckBoxBear.IsChecked == true;  // Tercera opción debe ser verdadera
            bool opcion4Correcta = CheckBoxBirds.IsChecked == false; // Cuarta opción debe ser falsa
            if (opcion1Correcta && opcion2Correcta && opcion3Correcta && opcion4Correcta)
            {
                // Respuesta correcta: incrementar puntuacion
                Puntuacion.Pregunta10 = 1;
                RespuestaCorrecta.Visibility = Visibility.Visible;
            }
            else
            {
                Puntuacion.Pregunta10 = 0;
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
