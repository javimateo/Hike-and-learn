﻿#pragma checksum "..\..\..\..\Ejercicio5\Ejercicio5_Pregunta2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3D3A35FD11822E0D61FF090333B9F818C70948AA"
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
using proyecto_1_evaluacion.Ejercicio5;


namespace proyecto_1_evaluacion.Ejercicio5 {
    
    
    /// <summary>
    /// Ejercicio5_Pregunta2
    /// </summary>
    public partial class Ejercicio5_Pregunta2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Ejercicio5\Ejercicio5_Pregunta2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxTrees;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Ejercicio5\Ejercicio5_Pregunta2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxSnow;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Ejercicio5\Ejercicio5_Pregunta2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxBear;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Ejercicio5\Ejercicio5_Pregunta2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxBirds;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Ejercicio5\Ejercicio5_Pregunta2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridBloqueo;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Ejercicio5\Ejercicio5_Pregunta2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RespuestaCorrecta;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Ejercicio5\Ejercicio5_Pregunta2.xaml"
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
            System.Uri resourceLocater = new System.Uri("/proyecto_1_evaluacion;component/ejercicio5/ejercicio5_pregunta2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Ejercicio5\Ejercicio5_Pregunta2.xaml"
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
            this.CheckBoxTrees = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.CheckBoxSnow = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.CheckBoxBear = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.CheckBoxBirds = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            
            #line 33 "..\..\..\..\Ejercicio5\Ejercicio5_Pregunta2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ConfirmarRespuesta_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gridBloqueo = ((System.Windows.Controls.Grid)(target));
            
            #line 35 "..\..\..\..\Ejercicio5\Ejercicio5_Pregunta2.xaml"
            this.gridBloqueo.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GridBloqueo_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RespuestaCorrecta = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.RespuestaIncorrecta = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

