﻿#pragma checksum "..\..\..\..\Window\AddVerbWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88DDA48816BE90F56D328136988A5AD98ECBED8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using AppVerbe.ViewModels;
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


namespace WPFUI {
    
    
    /// <summary>
    /// AddVerbWindow
    /// </summary>
    public partial class AddVerbWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\..\Window\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Window\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Temps;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Window\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PPS;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Window\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DPS;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\Window\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TPS;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\Window\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PPP;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Window\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DPP;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Window\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TPP;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\Window\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddVerb_Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFUI;V1.0.0.0;component/window/addverbwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Window\AddVerbWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\..\..\Window\AddVerbWindow.xaml"
            this.Name.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Temps = ((System.Windows.Controls.TextBox)(target));
            
            #line 68 "..\..\..\..\Window\AddVerbWindow.xaml"
            this.Temps.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PPS = ((System.Windows.Controls.TextBox)(target));
            
            #line 84 "..\..\..\..\Window\AddVerbWindow.xaml"
            this.PPS.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DPS = ((System.Windows.Controls.TextBox)(target));
            
            #line 89 "..\..\..\..\Window\AddVerbWindow.xaml"
            this.DPS.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TPS = ((System.Windows.Controls.TextBox)(target));
            
            #line 94 "..\..\..\..\Window\AddVerbWindow.xaml"
            this.TPS.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PPP = ((System.Windows.Controls.TextBox)(target));
            
            #line 99 "..\..\..\..\Window\AddVerbWindow.xaml"
            this.PPP.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DPP = ((System.Windows.Controls.TextBox)(target));
            
            #line 104 "..\..\..\..\Window\AddVerbWindow.xaml"
            this.DPP.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TPP = ((System.Windows.Controls.TextBox)(target));
            
            #line 109 "..\..\..\..\Window\AddVerbWindow.xaml"
            this.TPP.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddVerb_Button = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\..\..\Window\AddVerbWindow.xaml"
            this.AddVerb_Button.Click += new System.Windows.RoutedEventHandler(this.AddVerb_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 126 "..\..\..\..\Window\AddVerbWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetCurrentVerb_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

