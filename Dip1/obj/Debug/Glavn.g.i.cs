﻿#pragma checksum "..\..\Glavn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D9118D2F10C34A032CA1245111D2745B06AA02B278A33DDDE8DC05B4A69EEE67"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Dip1;
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


namespace Dip1 {
    
    
    /// <summary>
    /// Glavn
    /// </summary>
    public partial class Glavn : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\Glavn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Teacher;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Glavn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Awards;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Glavn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Internships;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Glavn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Attestations;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Glavn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Practices;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\Glavn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearch;
        
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
            System.Uri resourceLocater = new System.Uri("/Dip1;component/glavn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Glavn.xaml"
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
            this.Teacher = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Awards = ((System.Windows.Controls.TextBlock)(target));
            
            #line 49 "..\..\Glavn.xaml"
            this.Awards.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.AwardsE);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Internships = ((System.Windows.Controls.TextBlock)(target));
            
            #line 59 "..\..\Glavn.xaml"
            this.Internships.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.InternshipsE);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Attestations = ((System.Windows.Controls.TextBlock)(target));
            
            #line 69 "..\..\Glavn.xaml"
            this.Attestations.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.AttestationsE);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Practices = ((System.Windows.Controls.TextBlock)(target));
            
            #line 79 "..\..\Glavn.xaml"
            this.Practices.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.EnterPractice);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TBoxSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
