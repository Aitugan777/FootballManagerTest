﻿#pragma checksum "..\..\..\Pages\PageFootballClubs.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E7E520B97BDB9F8C47919FB86DD422941B481EA524EFA380416283D414B322D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FootballManager.Pages;
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


namespace FootballManager.Pages {
    
    
    /// <summary>
    /// PageFootballClubs
    /// </summary>
    public partial class PageFootballClubs : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Pages\PageFootballClubs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_RemoveClub;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\PageFootballClubs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_Content;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\PageFootballClubs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_NameClub;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Pages\PageFootballClubs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_CityClub;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Pages\PageFootballClubs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddFootballers;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Pages\PageFootballClubs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_RemoveFootballers;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Pages\PageFootballClubs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_Footballers;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Pages\PageFootballClubs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_SaveOrEdit;
        
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
            System.Uri resourceLocater = new System.Uri("/FootballManager;component/pages/pagefootballclubs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageFootballClubs.xaml"
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
            
            #line 40 "..\..\..\Pages\PageFootballClubs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnBtnClick_AddClub);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_RemoveClub = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\PageFootballClubs.xaml"
            this.btn_RemoveClub.Click += new System.Windows.RoutedEventHandler(this.OnBtnClick_RemoveClub);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lb_Content = ((System.Windows.Controls.ListBox)(target));
            
            #line 43 "..\..\..\Pages\PageFootballClubs.xaml"
            this.lb_Content.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectionChangedClub);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbx_NameClub = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbx_CityClub = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btn_AddFootballers = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\Pages\PageFootballClubs.xaml"
            this.btn_AddFootballers.Click += new System.Windows.RoutedEventHandler(this.OnBtnClick_AddFootballer);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_RemoveFootballers = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\Pages\PageFootballClubs.xaml"
            this.btn_RemoveFootballers.Click += new System.Windows.RoutedEventHandler(this.OnBtnClick_RemoveFootballer);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lb_Footballers = ((System.Windows.Controls.ListBox)(target));
            
            #line 105 "..\..\..\Pages\PageFootballClubs.xaml"
            this.lb_Footballers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectionChangedFootballer);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_SaveOrEdit = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\Pages\PageFootballClubs.xaml"
            this.btn_SaveOrEdit.Click += new System.Windows.RoutedEventHandler(this.OnBtnClick_SaveOrEdit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

