﻿#pragma checksum "..\..\..\..\..\Window\CustomizationWindows\CustomizeListMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BAFCC4406FF80D8BB4000F405ECB21FC6F9E9FC5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
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
using WPFUI.Window;


namespace WPFUI.Window {
    
    
    /// <summary>
    /// CustomizeListMenu
    /// </summary>
    public partial class CustomizeListMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\..\Window\CustomizationWindows\CustomizeListMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddVerb;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\Window\CustomizationWindows\CustomizeListMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteVerb;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\Window\CustomizationWindows\CustomizeListMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModifyVerb;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFUI;component/window/customizationwindows/customizelistmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Window\CustomizationWindows\CustomizeListMenu.xaml"
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
            this.AddVerb = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\..\Window\CustomizationWindows\CustomizeListMenu.xaml"
            this.AddVerb.Click += new System.Windows.RoutedEventHandler(this.OpenWindow_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DeleteVerb = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\..\Window\CustomizationWindows\CustomizeListMenu.xaml"
            this.DeleteVerb.Click += new System.Windows.RoutedEventHandler(this.OpenWindow_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ModifyVerb = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\..\Window\CustomizationWindows\CustomizeListMenu.xaml"
            this.ModifyVerb.Click += new System.Windows.RoutedEventHandler(this.OpenWindow_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
