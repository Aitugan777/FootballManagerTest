﻿#pragma checksum "..\..\..\Pages\PageFootballers.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F35A3F2A2E611FDCFFEF15D015F78CE77DD1C21833657F1AE7E536AE7BE76CC7"
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
    /// PageFootballers
    /// </summary>
    public partial class PageFootballers : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\Pages\PageFootballers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_Clubs;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\PageFootballers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_RemoveFootballer;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\PageFootballers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_Content;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Pages\PageFootballers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_Name;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Pages\PageFootballers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_SNILS;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\Pages\PageFootballers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_SelectDate;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\Pages\PageFootballers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_DateTime;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Pages\PageFootballers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_Club;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Pages\PageFootballers.xaml"
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
            System.Uri resourceLocater = new System.Uri("/FootballManager;component/pages/pagefootballers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageFootballers.xaml"
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
            this.cb_Clubs = ((System.Windows.Controls.ComboBox)(target));
            
            #line 47 "..\..\..\Pages\PageFootballers.xaml"
            this.cb_Clubs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectionChangedClub);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 54 "..\..\..\Pages\PageFootballers.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnBtnClick_AddFootballer);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_RemoveFootballer = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Pages\PageFootballers.xaml"
            this.btn_RemoveFootballer.Click += new System.Windows.RoutedEventHandler(this.OnBtnClick_RemoveFootballer);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lb_Content = ((System.Windows.Controls.ListBox)(target));
            
            #line 58 "..\..\..\Pages\PageFootballers.xaml"
            this.lb_Content.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectionChangedFootballer);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbx_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbx_SNILS = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btn_SelectDate = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\Pages\PageFootballers.xaml"
            this.btn_SelectDate.Click += new System.Windows.RoutedEventHandler(this.OnBtnClick_SelectDate);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbx_DateTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.cb_Club = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.btn_SaveOrEdit = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\Pages\PageFootballers.xaml"
            this.btn_SaveOrEdit.Click += new System.Windows.RoutedEventHandler(this.OnBtnClick_SaveOrEdit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

