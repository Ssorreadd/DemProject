﻿#pragma checksum "..\..\..\..\Pages\Main Page\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "985F02F117A639BEB564C39341AD396D2CE7657652055BD30303ECCCC1292BDD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace Project.MainPage {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Pages\Main Page\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TimeBlock;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\Main Page\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterRunnerButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\Main Page\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddViewerButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Pages\Main Page\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddSponsorButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Pages\Main Page\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EventInfoButton;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Pages\Main Page\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Project;component/pages/main%20page/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Main Page\MainPage.xaml"
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
            this.TimeBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.RegisterRunnerButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Pages\Main Page\MainPage.xaml"
            this.RegisterRunnerButton.Click += new System.Windows.RoutedEventHandler(this.RegisterRunnerButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddViewerButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.AddSponsorButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.EventInfoButton = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\Pages\Main Page\MainPage.xaml"
            this.EventInfoButton.Click += new System.Windows.RoutedEventHandler(this.EventInfoButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\Pages\Main Page\MainPage.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

