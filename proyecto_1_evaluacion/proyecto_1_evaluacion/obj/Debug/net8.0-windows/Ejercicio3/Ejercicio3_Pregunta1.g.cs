﻿#pragma checksum "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6E3D7D1967D7145B445A68411947FEA149040C2F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using proyecto_1_evaluacion.Ejercicio3;


namespace proyecto_1_evaluacion.Ejercicio3 {
    
    
    /// <summary>
    /// Ejercicio3_Pregunta1
    /// </summary>
    public partial class Ejercicio3_Pregunta1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider FixedSlider;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SliderValueText;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridBloqueo;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RespuestaCorrecta;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RespuestaIncorrecta;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/proyecto_1_evaluacion;component/ejercicio3/ejercicio3_pregunta1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FixedSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 32 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta1.xaml"
            this.FixedSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.FixedSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SliderValueText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            
            #line 42 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ConfirmarRespuesta_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gridBloqueo = ((System.Windows.Controls.Grid)(target));
            
            #line 44 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta1.xaml"
            this.gridBloqueo.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GridBloqueo_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RespuestaCorrecta = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.RespuestaIncorrecta = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

