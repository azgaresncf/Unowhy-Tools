﻿// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Wpf.Ui.Common.Interfaces;
using Unowhy_Tools_WPF.ViewModels;
using System.Threading.Tasks;
using Unowhy_Tools_WPF.Views;
using System.Windows;
using System.Diagnostics;
using Wpf.Ui.Common;
using Wpf.Ui.Mvvm.Contracts;
using Wpf.Ui.Mvvm.Services;

namespace Unowhy_Tools_WPF.Views.Pages;

/// <summary>
/// Interaction logic for Dashboard.xaml
/// </summary>
public partial class About : INavigableView<DashboardViewModel>
{
    private readonly ISnackbarService _snackbarService;

    public DashboardViewModel ViewModel
    {
        get;
    }

    public About(DashboardViewModel viewModel, ISnackbarService snackbarService)
    {
        ViewModel = viewModel;
        InitializeComponent();

        _snackbarService = snackbarService;

    }

    public void Github_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        System.Diagnostics.Process.Start(new ProcessStartInfo
        {
            FileName = "https://github.com/STY1001/Unowhy-Tools",
                        UseShellExecute = true
        });
    }

    public void STY1001_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        System.Diagnostics.Process.Start(new ProcessStartInfo
        {
            FileName = "https://sty1001.cf",
            UseShellExecute = true
        });
    }

    public void Discord_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        System.Diagnostics.Process.Start(new ProcessStartInfo
        {
            FileName = "https://discord.com/invite/dw3ZJ9u7WS",
            UseShellExecute = true
        });
    }

    public void Update_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        _snackbarService.Show("Update checker", "Not done", SymbolRegular.ErrorCircle24, ControlAppearance.Danger);
    }
}
