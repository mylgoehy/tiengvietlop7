﻿#pragma checksum "..\..\GrammarPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "363664745FD642C2C61598083BC62D4D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace TiengViet7 {
    
    
    /// <summary>
    /// GrammarPage
    /// </summary>
    public partial class GrammarPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\GrammarPage.xaml"
        internal System.Windows.Controls.ListBox GrammarLessonList;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\GrammarPage.xaml"
        internal System.Windows.Shapes.Rectangle Banner;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\GrammarPage.xaml"
        internal System.Windows.Controls.Canvas canMain;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\GrammarPage.xaml"
        internal System.Windows.Controls.TextBlock tbmarquee;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\GrammarPage.xaml"
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TiengViet7;component/grammarpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GrammarPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\GrammarPage.xaml"
            ((TiengViet7.GrammarPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.GrammarPage_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GrammarLessonList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.Banner = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.canMain = ((System.Windows.Controls.Canvas)(target));
            return;
            case 5:
            this.tbmarquee = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\GrammarPage.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}