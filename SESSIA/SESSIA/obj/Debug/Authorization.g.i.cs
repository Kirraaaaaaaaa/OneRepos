﻿#pragma checksum "..\..\Authorization.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F71F50BF5EB5BEEA01FB0FB851939FB1485C0A91A13A703C0EA320BF4D50DEAE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SESSIA;
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


namespace SESSIA {
    
    
    /// <summary>
    /// Authorization
    /// </summary>
    public partial class Authorization : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login_TB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password_PB;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Authorization_BTN;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Guest_BTN;
        
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
            System.Uri resourceLocater = new System.Uri("/SESSIA;component/authorization.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Authorization.xaml"
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
            this.Login_TB = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\Authorization.xaml"
            this.Login_TB.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Login_Password_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Password_PB = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 21 "..\..\Authorization.xaml"
            this.Password_PB.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Login_Password_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Authorization_BTN = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Authorization.xaml"
            this.Authorization_BTN.Click += new System.Windows.RoutedEventHandler(this.Authorization_BTN_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Guest_BTN = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Authorization.xaml"
            this.Guest_BTN.Click += new System.Windows.RoutedEventHandler(this.Guest_BTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

