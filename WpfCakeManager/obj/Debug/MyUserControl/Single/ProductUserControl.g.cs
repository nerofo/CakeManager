﻿#pragma checksum "..\..\..\..\MyUserControl\Single\ProductUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EC2D644FBA7303D3F54C6F24B7A420B7"
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
    /// ProductUserControl
    /// </summary>
    public partial class ProductUserControl : WpfCakeManager.MyUserControl.BaseUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\MyUserControl\Single\ProductUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfCakeManager.MyUserControl.Single.CategoryUserControl CategoryUserControl;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\MyUserControl\Single\ProductUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProductIdTxtB;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\MyUserControl\Single\ProductUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProductNameTxtB;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\MyUserControl\Single\ProductUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProductPriceTxtB;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\MyUserControl\Single\ProductUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProductQuantityTxtB;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfCakeManager;component/myusercontrol/single/productusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MyUserControl\Single\ProductUserControl.xaml"
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
            this.CategoryUserControl = ((WpfCakeManager.MyUserControl.Single.CategoryUserControl)(target));
            return;
            case 2:
            this.ProductIdTxtB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ProductNameTxtB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ProductPriceTxtB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ProductQuantityTxtB = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

