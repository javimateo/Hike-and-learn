﻿#pragma checksum "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CA18260AE03437877C252F1687BB6A5C0BD8BD8C"
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
    /// Ejercicio3_Pregunta2
    /// </summary>
    public partial class Ejercicio3_Pregunta2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BearDropTarget;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DeerDropTarget;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image BearImage;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image DeerImage;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridBloqueo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RespuestaCorrecta;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
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
            System.Uri resourceLocater = new System.Uri("/proyecto_1_evaluacion;component/ejercicio3/ejercicio3_pregunta2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
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
            this.BearDropTarget = ((System.Windows.Controls.TextBlock)(target));
            
            #line 19 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
            this.BearDropTarget.Drop += new System.Windows.DragEventHandler(this.Bear_Drop);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
            this.BearDropTarget.DragEnter += new System.Windows.DragEventHandler(this.DragEnter);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
            this.BearDropTarget.DragLeave += new System.Windows.DragEventHandler(this.DragLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DeerDropTarget = ((System.Windows.Controls.TextBlock)(target));
            
            #line 22 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
            this.DeerDropTarget.Drop += new System.Windows.DragEventHandler(this.Deer_Drop);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
            this.DeerDropTarget.DragEnter += new System.Windows.DragEventHandler(this.DragEnter);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
            this.DeerDropTarget.DragLeave += new System.Windows.DragEventHandler(this.DragLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BearImage = ((System.Windows.Controls.Image)(target));
            
            #line 30 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
            this.BearImage.MouseMove += new System.Windows.Input.MouseEventHandler(this.Image_MouseMove);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeerImage = ((System.Windows.Controls.Image)(target));
            
            #line 33 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
            this.DeerImage.MouseMove += new System.Windows.Input.MouseEventHandler(this.Image_MouseMove);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 37 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ConfirmarRespuesta_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gridBloqueo = ((System.Windows.Controls.Grid)(target));
            
            #line 38 "..\..\..\..\Ejercicio3\Ejercicio3_Pregunta2.xaml"
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

