﻿using Wpf.Ui.Common.Interfaces;
using Unowhy_Tools_WPF.ViewModels;
using System.Diagnostics;
using Wpf.Ui.Common;
using Wpf.Ui.Mvvm.Contracts;

using Unowhy_Tools;
using System.Windows;
using System.Threading;
using System.Threading.Tasks;
using System;
using System.IO.Compression;
using System.IO;
using System.Net.Http;
using System.Windows.Media.Animation;
using System.Windows.Controls;
using System.Windows.Media;
using System.IO.Pipes;
using Wpf.Ui.Interop.WinDef;
using Unowhy_Tools_WPF.Services.Contracts;
using System.Net;
using System.Reflection.Metadata;
using System.Linq;
using System.Data;
using System.Collections.Generic;

namespace Unowhy_Tools_WPF.Views.Pages;

/// <summary>
/// Interaction logic for Dashboard.xaml
/// </summary>
public partial class DebugPage : INavigableView<DashboardViewModel>
{
    NamedPipeClientStream pipeClient;
    UT.Data UTdata = new UT.Data();

    [System.Runtime.InteropServices.DllImport("kernel32.dll")]
    private static extern bool AllocConsole();

    private readonly ITestWindowService _testWindowService;
    private readonly ISnackbarService _snackbarService;

    public DashboardViewModel ViewModel
    {
        get;
    }

    public DebugPage(DashboardViewModel viewModel, ISnackbarService snackbarService, ITestWindowService testWindowService)
    {
        ViewModel = viewModel;
        InitializeComponent();

        ODupdate();

        _testWindowService = testWindowService;
        _snackbarService = snackbarService;
    }

    public async void ODupdate()
    {
        ODataBox.Text = await UT.Config.Get("OnlineData");
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
        UT.NavigateTo(typeof(Wifi));
    }

    public async void Discord_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        
    }

    public async void Update_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        debus.Text = "Downloading...";
        string utemp = UT.utpath + "\\Unowhy Tools\\Temps";
        var progress = new System.Progress<double>();
        var cancellationToken = new CancellationTokenSource();
        progress.ProgressChanged += (sender, value) =>
        {
            debus.Text = "Downloading... (" + value.ToString("##0") + "%)";
        };
        await UT.DlFilewithProgress(await UT.OnlineDatas.GetUrls("utdebupdatezip"), utemp + "\\update.zip", progress, cancellationToken.Token);
        progress = new System.Progress<double>();
        cancellationToken = new CancellationTokenSource();
        progress.ProgressChanged += (sender, value) =>
        {
            debus.Text = "Downloading... (" + value.ToString("##0") + "%)";
        };
        await UT.DlFilewithProgress(await UT.OnlineDatas.GetUrls("utuninstaller"), utemp + "\\Update\\uninstall.exe", progress, cancellationToken.Token);
        debus.Text = "Extracting...";
        ZipFile.ExtractToDirectory(utemp + "\\update.zip", utemp + "\\Update");
        string pre = utemp + "\\update";
        string post = Directory.GetCurrentDirectory();

        Process.Start("cmd.exe", $"/c echo Updating Unowhy Tools... & taskkill /f /im \"Unowhy Tools.exe\" & net stop UTS & timeout -t 3 & del /s /q \"{post}\\*\" & xcopy \"{pre}\" \"{post}\" /e /h /c /i /y & echo Done ! & powershell -windows hidden -command \"\" & \"Unowhy Tools.exe\" -user {UTdata.UserID}");

    }   

    public void al_click(object sender, System.Windows.RoutedEventArgs e)
    {
        UT.applylang_global();
    }

    public void DialoQ_Test(object sender, System.Windows.RoutedEventArgs e)
    {
        if (UT.DialogQShow(dialogtxt.Text, "question.png") == true)
        {
            dqtest.Content = "YES";
        }
        else
        {
            dqtest.Content = "NO";
        }
    }

    public void DialogI_Test(object sender, System.Windows.RoutedEventArgs e)
    {
        UT.DialogIShow(dialogtxt.Text, "about.png");
    }

    private async void Button_Click(object sender, RoutedEventArgs e)
    {
        //UT.anim.BackBtnAnim(backbtn);
        await Task.Delay(150);
        //UT.anim.TransitionBack(Grid1);
        await Task.Delay(200);
        UT.NavigateTo(typeof(Dashboard));
    }

    private async void Button_Click_1(object sender, RoutedEventArgs e)
    {
        string rep = await UT.UTS.UTSmsg(pipe.Text, msg.Text);
        UT.DialogIShow(rep, "about.png");
    }

    private async void LaunchDebugTray()
    {
        try
        {
            _testWindowService.Show<Views.TrayWindow>();
        }
        catch (Exception ex)
        {
            UT.DialogIShow(ex.ToString(), "no.png");
        }
    }

    private void Button_Click_2(object sender, RoutedEventArgs e)
    {
        try
        {
            LaunchDebugTray();
        }
        catch (Exception ex)
        {
            UT.DialogIShow(ex.ToString(), "no.png");
        }
    }

    private async void UiPage_Unloaded(object sender, RoutedEventArgs e)
    {
        //UT.anim.TransitionBack(Grid1);
    }

    private void Button_Click_3(object sender, RoutedEventArgs e)
    {
        var mainWindow = System.Windows.Application.Current.MainWindow as Unowhy_Tools_WPF.Views.MainWindow;
        mainWindow.ChangeTheme();
    }

    private void Button_Click_4(object sender, RoutedEventArgs e)
    {
        AllocConsole();
    }

    private async void UiPage_Loaded(object sender, RoutedEventArgs e)
    {
        await UT.DeployBack(typeof(Dashboard), RootGrid, RootBorder);
        await UT.anim.BorderZoomOut(RootBorder);
    }

    private async void Button_Click_5(object sender, RoutedEventArgs e)
    {
        await UT.anim.BorderZoomIn2(RootBorder);
        UT.NavigateTo(typeof(Dashboard));
    }

    private async void download_Click(object sender, RoutedEventArgs e)
    {
        var progress = new System.Progress<double>();
        progress.ProgressChanged += (sender, value) =>
        {
            download.Content = "Download " + value.ToString("###.#") + "%";
        };

        var cancellationToken = new CancellationTokenSource();

        await UT.DlFilewithProgress(url.Text, path.Text, progress, cancellationToken.Token);
        download.Content = "Download";
    }

    private void getdate_Click(object sender, RoutedEventArgs e)
    {
        dateview.Text = datepick.SelectedDate.Value.ToString("MM/dd/yyyy");
    }

    private async void Button_Click_6(object sender, RoutedEventArgs e)
    {
        if (odataavatar.IsSelected)
        {
            string result = await UT.OnlineDatas.GetUrls(odataget.Text);
            UT.DialogIShow(result, "about.png");
        }
        else if (odatastring.IsSelected)
        {
            string result = await UT.OnlineDatas.GetStrings(odataget.Text);
            UT.DialogIShow(result, "about.png");
        }
        else if (odataupdate.IsSelected)
        {
            string result = await UT.OnlineDatas.GetUpdates(odataget.Text);
            UT.DialogIShow(result, "about.png");
        }
        else if (odataurl.IsSelected)
        {
            string result = await UT.OnlineDatas.GetUrls(odataget.Text);
            UT.DialogIShow(result, "about.png");
        }
    }

    private async void Button_Click_7(object sender, RoutedEventArgs e)
    {
        List<string> list = new List<string>();
        foreach (string filePath in Directory.GetFiles(scanpath.Text, scantype.Text))
        {
            list.Add(filePath);
        }
        foreach (string subDirectory in Directory.GetDirectories(scanpath.Text))
        {
            foreach (string filePath in Directory.GetFiles(subDirectory, scantype.Text))
            {
                list.Add(filePath);
            }
        }
        string result = list.Count.ToString();

        foreach (string filePath in list)
        {
            result = result + Environment.NewLine + filePath;
        }

        UT.DialogIShow(result, "about.png");
    }

    private async void Button_Click_8(object sender, RoutedEventArgs e)
    {
        await UT.Config.Set("OnlineData", ODataBox.Text);
        UT.online_datas = ODataBox.Text;
    }
}

