﻿#pragma checksum "..\..\..\GetTeachersDetails.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F04C8ADD2B7DF290E47729B8919B9E991929AE6A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// GetTeachersDetails
    /// </summary>
    public partial class GetTeachersDetails : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\GetTeachersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label header;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\GetTeachersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TeachersGetValues;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\GetTeachersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image blurimage;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\GetTeachersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid EnterPasswordTeacher;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\GetTeachersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Pass;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\GetTeachersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Pass_Placeholder;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/getteachersdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GetTeachersDetails.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.header = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            
            #line 14 "..\..\..\GetTeachersDetails.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Logout_Icon_GetPage);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TeachersGetValues = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            
            #line 44 "..\..\..\GetTeachersDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_Button_teacher_Get);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 60 "..\..\..\GetTeachersDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Button_School_Get);
            
            #line default
            #line hidden
            return;
            case 6:
            this.blurimage = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.EnterPasswordTeacher = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.Pass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 98 "..\..\..\GetTeachersDetails.xaml"
            this.Pass.PasswordChanged += new System.Windows.RoutedEventHandler(this.pass_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 113 "..\..\..\GetTeachersDetails.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDownTeacher);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Pass_Placeholder = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

