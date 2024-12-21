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
    /// Lógica de interacción para Ejercicio3_Pregunta3.xaml
    /// </summary>
    public partial class Ejercicio3_Pregunta2 : Page
    {
        private readonly Ejercicio3 _parentWindow;
        private bool osoEsCorrecto, ciervoEsCorrecto;
        public Ejercicio3_Pregunta2(Ejercicio3 parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
        }

        private void ConfirmarRespuesta_Click(object sender, RoutedEventArgs e)
        {
            if (osoEsCorrecto && ciervoEsCorrecto)
            {
                // Respuesta correcta: incrementar puntuacion
                Puntuacion.Pregunta6 = 1;
                RespuestaCorrecta.Visibility = Visibility.Visible;
            }
            else
            {
                Puntuacion.Pregunta6 = 0;
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
        private void Image_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Image image = sender as Image;
                if (image != null)
                {
                    // Inicia el drag and drop con el nombre del objeto
                    DragDrop.DoDragDrop(image, image.Name, DragDropEffects.Move);
                }
            }
        }

        private void Bear_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.StringFormat) as string == "BearImage")
            {
                MessageBox.Show("Correct! Bear is matched!");
                ((TextBlock)sender).Background = Brushes.LightGreen;
                osoEsCorrecto = true;
            }
            else
            {
                MessageBox.Show("Incorrect! Try again.");
                osoEsCorrecto = false;

            }
        }

        private void Deer_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.StringFormat) as string == "DeerImage")
            {
                MessageBox.Show("Correct! Deer is matched!");
                ((TextBlock)sender).Background = Brushes.LightGreen;
                ciervoEsCorrecto = true;
            }
            else
            {
                MessageBox.Show("Incorrect! Try again.");
                ciervoEsCorrecto = false;
            }
        }

        private void DragEnter(object sender, DragEventArgs e)
        {
            TextBlock target = sender as TextBlock;
            if (target != null)
            {
                target.Background = Brushes.LightYellow; // Indicar que el objeto está siendo arrastrado sobre él
            }
        }

        private void DragLeave(object sender, DragEventArgs e)
        {
            TextBlock target = sender as TextBlock;
            if (target != null)
            {
                target.Background = Brushes.Transparent; // Restaurar el fondo original
            }
        }

    }
}
