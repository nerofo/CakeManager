﻿#pragma checksum "..\..\..\..\MyUserControl\Single\ClientUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DA345CCA9C98C3D078D9F7454C519A67"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using System.Windows.Shell;
using WpfCakeManager.MyUserControl;
using WpfCakeManager.MyUserControl.Single;


namespace WpfCakeManager.MyUserControl.Single {
    
    
    /// <summary>
    /// ClientUserControl
    /// </summary>
    public partial class ClientUserControl : WpfCakeManager.MyUserControl.BaseUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\MyUserControl\Single\ClientUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ClientIdTxtB;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\MyUserControl\Single\ClientUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClientNameTxtB;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\MyUserControl\Single\ClientUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClientPhoneTxtB;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\MyUserControl\Single\ClientUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClientMailTxtB;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\MyUserControl\Single\ClientUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfCakeManager.MyUserControl.Single.AddressUserControl AddressUserControl;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfCakeManager;component/myusercontrol/single/clientusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MyUserControl\Single\ClientUserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.ClientIdTxtB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ClientNameTxtB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ClientPhoneTxtB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ClientMailTxtB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddressUserControl = ((WpfCakeManager.MyUserControl.Single.AddressUserControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

