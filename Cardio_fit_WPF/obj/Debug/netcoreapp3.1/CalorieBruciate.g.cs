﻿#pragma checksum "..\..\..\CalorieBruciate.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8B69B33D176EE95517BDA59411A6AA3B9DBFD13E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cardio_fit_WPF;
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


namespace Cardio_fit_WPF {
    
    
    /// <summary>
    /// CalorieBruciate
    /// </summary>
    public partial class CalorieBruciate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\CalorieBruciate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBattiti;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\CalorieBruciate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalcola;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\CalorieBruciate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblStampa;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\CalorieBruciate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtUomo;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\CalorieBruciate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtDonna;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\CalorieBruciate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPeso;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\CalorieBruciate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEta;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\CalorieBruciate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDurata;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Cardio_fit_WPF;component/caloriebruciate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CalorieBruciate.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtBattiti = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnCalcola = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\CalorieBruciate.xaml"
            this.btnCalcola.Click += new System.Windows.RoutedEventHandler(this.btnCalcola_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblStampa = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.rbtUomo = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.rbtDonna = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.txtPeso = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtEta = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtDurata = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
