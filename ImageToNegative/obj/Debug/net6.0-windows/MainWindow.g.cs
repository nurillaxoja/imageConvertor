﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30DCEACB196BCA1143F30C5A9D7C4A5323F19892"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ImageToNegative;
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


namespace ImageToNegative {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miOpen;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miChangeTo;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miBinary;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miGrayscaled;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miNegative;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miRed;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miGreen;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miBlue;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miSaveAs;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miExit;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbImgLocation;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgOriginal;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ImageToNegative;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.miOpen = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\..\MainWindow.xaml"
            this.miOpen.Click += new System.Windows.RoutedEventHandler(this.miOpen_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.miChangeTo = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            this.miBinary = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\..\MainWindow.xaml"
            this.miBinary.Click += new System.Windows.RoutedEventHandler(this.miBinary_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.miGrayscaled = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\MainWindow.xaml"
            this.miGrayscaled.Click += new System.Windows.RoutedEventHandler(this.miGrayscaled_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.miNegative = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\..\MainWindow.xaml"
            this.miNegative.Click += new System.Windows.RoutedEventHandler(this.miNegative_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.miRed = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\..\MainWindow.xaml"
            this.miRed.Click += new System.Windows.RoutedEventHandler(this.miRed_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.miGreen = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\MainWindow.xaml"
            this.miGreen.Click += new System.Windows.RoutedEventHandler(this.miGreen_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.miBlue = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\..\MainWindow.xaml"
            this.miBlue.Click += new System.Windows.RoutedEventHandler(this.miBlue_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.miSaveAs = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.miSaveAs.Click += new System.Windows.RoutedEventHandler(this.miSaveAs_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.miExit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 23 "..\..\..\MainWindow.xaml"
            this.miExit.Click += new System.Windows.RoutedEventHandler(this.miExit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txbImgLocation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.imgOriginal = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

