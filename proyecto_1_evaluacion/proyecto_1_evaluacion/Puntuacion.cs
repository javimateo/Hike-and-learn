using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1_evaluacion
{
    public static class Puntuacion
    {
        // Propiedades automáticas para cada pregunta
        public static int Pregunta1 { get; set; } = 0;
        public static int Pregunta2 { get; set; } = 0;
        public static int Pregunta3 { get; set; } = 0;
        public static int Pregunta4 { get; set; } = 0;
        public static int Pregunta5 { get; set; } = 0;
        public static int Pregunta6 { get; set; } = 0;
        public static int Pregunta7 { get; set; } = 0;
        public static int Pregunta8 { get; set; } = 0;
        public static int Pregunta9 { get; set; } = 0;
        public static int Pregunta10 { get; set; } = 0;

        // Propiedad para los puntos totales
        private static int puntos;
        public static int Puntos
        {
            get { return puntos; }
            set { puntos = value; } // Solo puede ser modificado internamente
        }

        // Metodo para calcular los puntos
        public static void CalcularPuntos()
        {
            Puntos = Pregunta1 + Pregunta2 + Pregunta3 + Pregunta4 + Pregunta5 +
                     Pregunta6 + Pregunta7 + Pregunta8 + Pregunta9 + Pregunta10;
        }

    }
}
