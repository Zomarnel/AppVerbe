#pragma checksum "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4EDEE2C607EB3F0A03A92A8E10FD9F36D6B35CEE"
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
        
        
        #line 54 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Temps;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PPS;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DPS;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TPS;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PPP;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DPP;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TPP;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WPFUI;V1.0.0.0;component/window/customizationwindows/addverbwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
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
            
            #line 58 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
            this.Name.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Temps = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
            this.Temps.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PPS = ((System.Windows.Controls.TextBox)(target));
            
            #line 93 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
            this.PPS.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DPS = ((System.Windows.Controls.TextBox)(target));
            
            #line 100 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
            this.DPS.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TPS = ((System.Windows.Controls.TextBox)(target));
            
            #line 107 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
            this.TPS.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PPP = ((System.Windows.Controls.TextBox)(target));
            
            #line 114 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
            this.PPP.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DPP = ((System.Windows.Controls.TextBox)(target));
            
            #line 121 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
            this.DPP.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TPP = ((System.Windows.Controls.TextBox)(target));
            
            #line 128 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
            this.TPP.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MoveToTheNextTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddVerb_Button = ((System.Windows.Controls.Button)(target));
            
            #line 141 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
            this.AddVerb_Button.Click += new System.Windows.RoutedEventHandler(this.AddVerb_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 145 "..\..\..\..\..\Window\CustomizationWindows\AddVerbWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetCurrentVerb_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

