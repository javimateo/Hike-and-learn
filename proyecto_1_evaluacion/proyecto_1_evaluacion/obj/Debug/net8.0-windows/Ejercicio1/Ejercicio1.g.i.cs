﻿#pragma checksum "..\..\..\..\Ejercicio1\Ejercicio1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05FC72BF1C9799C10C790E009046104D1C3AE284"
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


namespace proyecto_1_evaluacion {
    
    
    /// <summary>
    /// Ejercicio1
    /// </summary>
    public partial class Ejercicio1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Ejercicio1\Ejercicio1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Pregunta1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Ejercicio1\Ejercicio1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Pregunta2;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Ejercicio1\Ejercicio1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridPantallaPuntuacion;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Ejercicio1\Ejercicio1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockPuntuacion;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Ejercicio1\Ejercicio1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridBloqueo;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Ejercicio1\Ejercicio1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagenSuperado;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Ejercicio1\Ejercicio1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagenFallido;
        
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
            System.Uri resourceLocater = new System.Uri("/proyecto_1_evaluacion;V1.0.0.0;component/ejercicio1/ejercicio1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Ejercicio1\Ejercicio1.xaml"
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
            this.Pregunta1 = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.Pregunta2 = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.gridPantallaPuntuacion = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.textBlockPuntuacion = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 50 "..\..\..\..\Ejercicio1\Ejercicio1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.VolverAPantallaPrincipal_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gridBloqueo = ((System.Windows.Controls.Grid)(target));
            
            #line 53 "..\..\..\..\Ejercicio1\Ejercicio1.xaml"
            this.gridBloqueo.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GridBloqueo_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.imagenSuperado = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.imagenFallido = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

