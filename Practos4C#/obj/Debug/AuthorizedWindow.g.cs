﻿#pragma checksum "..\..\AuthorizedWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "04147C0499710676F993E8F8D9C1FE2895BADF405EE16D634DEE509EB5194613"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Practos4C_;
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


namespace Practos4C_ {
    
    
    /// <summary>
    /// AuthorizedWindow
    /// </summary>
    public partial class AuthorizedWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\AuthorizedWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TestEditorPage;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AuthorizedWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TestGrid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AuthorizedWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TestPassingPage;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AuthorizedWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QuestionTitleTextBlock;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AuthorizedWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DescriptionTextBlock;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AuthorizedWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Answer1Button;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AuthorizedWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Answer2Button;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AuthorizedWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Answer3Button;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AuthorizedWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel NoTestPage;
        
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
            System.Uri resourceLocater = new System.Uri("/Practos4C#;component/authorizedwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AuthorizedWindow.xaml"
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
            this.TestEditorPage = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TestGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            
            #line 20 "..\..\AuthorizedWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveTestData);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 21 "..\..\AuthorizedWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ReturnToAuthorizationWindow);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TestPassingPage = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.QuestionTitleTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.DescriptionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Answer1Button = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\AuthorizedWindow.xaml"
            this.Answer1Button.Click += new System.Windows.RoutedEventHandler(this.Answer1Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Answer2Button = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\AuthorizedWindow.xaml"
            this.Answer2Button.Click += new System.Windows.RoutedEventHandler(this.Answer2Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Answer3Button = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\AuthorizedWindow.xaml"
            this.Answer3Button.Click += new System.Windows.RoutedEventHandler(this.Answer3Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.NoTestPage = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

