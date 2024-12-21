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

namespace proyecto_1_evaluacion.Ejercicio2
{
    /// <summary>
    /// Lógica de interacción para Ejercicio2_Pregunta1.xaml
    /// </summary>
    public partial class Ejercicio2_Pregunta1 : Page
    {
        private readonly Ejercicion2 _parentWindow;

        public Ejercicio2_Pregunta1(Ejercicion2 parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
        }

        private void ConfirmarRespuesta_Click(object sender, RoutedEventArgs e)
        {
            // Obtener las opciones seleccionadas de los ComboBox
            ComboBoxItem selectedAnimal = (ComboBoxItem)ComboBox1Pregunta3.SelectedItem;
            ComboBoxItem selectedDrink = (ComboBoxItem)ComboBox2Pregunta3.SelectedItem;

            // Comprobar si las selecciones son correctas
            bool isAnimalCorrect = selectedAnimal != null && selectedAnimal.Content.ToString() == "Hedgehog";
            bool isDrinkCorrect = selectedDrink != null && selectedDrink.Content.ToString() == "Coffee";

            if (isAnimalCorrect && isDrinkCorrect)
            {
                Puntuacion.Pregunta3 = 1;
                RespuestaCorrecta.Visibility = Visibility.Visible;
            }
            else
            {
                Puntuacion.Pregunta3 = 0;
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
