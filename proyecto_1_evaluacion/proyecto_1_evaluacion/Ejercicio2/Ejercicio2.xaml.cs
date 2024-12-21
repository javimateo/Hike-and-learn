﻿using proyecto_1_evaluacion.Ejercicio2;
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

namespace proyecto_1_evaluacion
{
    /// <summary>
    /// Lógica de interacción para Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicion2 : Window
    {
        private readonly MainWindow _parentWindow;
        public Ejercicion2(MainWindow parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
            // Cargar la primera pregunta en el Frame de Pregunta1
            Pregunta1.Content = new Ejercicio2_Pregunta1(this);
        }

        // Metodo para cambiar al frame de la siguiente pregunta
        public void IrASiguientePregunta()
        {
            // Ocultar el frame de Pregunta1
            Pregunta1.Visibility = Visibility.Collapsed;

            // Mostrar el frame de Pregunta2
            Pregunta2.Visibility = Visibility.Visible;
            Pregunta2.Content = new Ejercicio2_Pregunta2(this);
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
            if (Puntuacion.Pregunta3 == 1 && Puntuacion.Pregunta4 == 1)
            {
                _parentWindow.BotonEjercicio3.Style = (Style)this.FindResource("CircularTransparentButtonStyle");
            }
            _parentWindow.ActualizarProgreso();
            this.Close();
        }
    }
}
