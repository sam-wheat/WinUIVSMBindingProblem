// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIVSMBindingProblem;
public sealed class VSMCustomControl : Control
{

    public ICommand ButtonCommand
    {
        get { return (ICommand)GetValue(ButtonCommandProperty); }
        set { SetValue(ButtonCommandProperty, value); }
    }

    public static readonly DependencyProperty ButtonCommandProperty =
        DependencyProperty.Register("ButtonCommand", typeof(ICommand), typeof(VSMCustomControl), new PropertyMetadata(null));


    public bool IsClicked
    {
        get { return (bool)GetValue(IsClickedProperty); }
        set { SetValue(IsClickedProperty, value); }
    }
    
    public static readonly DependencyProperty IsClickedProperty =
        DependencyProperty.Register("IsClicked", typeof(bool), typeof(VSMCustomControl), new PropertyMetadata(false));


    public VSMCustomControl()
    {
        this.DefaultStyleKey = typeof(VSMCustomControl);

        ButtonCommand = new RelayCommand(() =>
        {
            IsClicked = !IsClicked;
        });
    }
}
