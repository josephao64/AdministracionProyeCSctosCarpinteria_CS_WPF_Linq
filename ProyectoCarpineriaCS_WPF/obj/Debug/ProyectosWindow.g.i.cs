﻿#pragma checksum "..\..\ProyectosWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "356ADCA85C954CA2DB58F52EF20D0731EC49D96EABC7E9740B5D1E8DEDDA652C"
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


namespace ProyectoCarpineriaCS_WPF {
    
    
    /// <summary>
    /// ProyectosWindow
    /// </summary>
    public partial class ProyectosWindow : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\ProyectosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProyectosGrid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ProyectosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtId;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ProyectosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNombre;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ProyectosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtTelefono;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ProyectosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtDescripcion;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ProyectosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FechaInicioPicker;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ProyectosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FechaFinPicker;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ProyectosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPrecio;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ProyectosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAgregar;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ProyectosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEliminar;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ProyectosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnActualizar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProyectoCarpineriaCS_WPF;component/proyectoswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProyectosWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ProyectosGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\ProyectosWindow.xaml"
            this.ProyectosGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProyectosGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxtId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxtTelefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxtDescripcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.FechaInicioPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.FechaFinPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.TxtPrecio = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.BtnAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\ProyectosWindow.xaml"
            this.BtnAgregar.Click += new System.Windows.RoutedEventHandler(this.BtnAgregar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\ProyectosWindow.xaml"
            this.BtnEliminar.Click += new System.Windows.RoutedEventHandler(this.BtnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BtnActualizar = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\ProyectosWindow.xaml"
            this.BtnActualizar.Click += new System.Windows.RoutedEventHandler(this.BtnActualizar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

