﻿#pragma checksum "..\..\AddContractWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "112459CEC80452BB6BBFD8079E87E42513792FADECB4EAAB89CAFBB8099D3969"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseMarketing;
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


namespace CourseMarketing {
    
    
    /// <summary>
    /// AddContractWindow
    /// </summary>
    public partial class AddContractWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AddContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NContractBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\AddContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DateCreationBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AddContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DateExecBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddContractButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FIOClientCombo;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AddContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PayStatusBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AddContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StatusContcractBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ServiceContractBox;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseMarketing;component/addcontractwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddContractWindow.xaml"
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
            this.NContractBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DateCreationBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DateExecBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DescriptionBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddContractButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\AddContractWindow.xaml"
            this.AddContractButton.Click += new System.Windows.RoutedEventHandler(this.AddContractButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FIOClientCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.PayStatusBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.StatusContcractBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.ServiceContractBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
