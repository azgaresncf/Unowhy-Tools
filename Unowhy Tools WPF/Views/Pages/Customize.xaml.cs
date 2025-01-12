﻿using Wpf.Ui.Common.Interfaces;
using Unowhy_Tools_WPF.ViewModels;

using Unowhy_Tools;
using System.Threading.Tasks;
using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Media;

namespace Unowhy_Tools_WPF.Views.Pages;

/// <summary>
/// Interaction logic for Dashboard.xaml
/// </summary>
public partial class Customize : INavigableView<DashboardViewModel>
{
    UT.Data UTdata = new UT.Data();

    public DashboardViewModel ViewModel
    {
        get;
    }

    public void GoForw(object sender, RoutedEventArgs e)
    {
        
    }
    
    public async void AdminSet_Click(object sender, RoutedEventArgs e)
    {
        DoubleAnimation anim = new DoubleAnimation();
        anim.From = 0;
        anim.To = 300;
        anim.Duration = TimeSpan.FromMilliseconds(500);
        anim.EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseInOut, Power = 5 };
        TranslateTransform trans = new TranslateTransform();
        auset_btn.RenderTransform = trans;
        trans.BeginAnimation(TranslateTransform.XProperty, anim);

        UT.anim.RegisterParent(RootGrid, RootBorder);
        UT.anim.AnimParent("zoomout2");
        await Task.Delay(500);
        UT.NavigateTo(typeof(AdminUser));

        anim.From = 0;
        anim.To = 0;
        anim.Duration = TimeSpan.FromMilliseconds(500);
        anim.EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseInOut, Power = 5 };
        auset_btn.RenderTransform = trans;
        trans.BeginAnimation(TranslateTransform.XProperty, anim);
    }
    
    public async void AddUser_Click(object sender, RoutedEventArgs e)
    {
        DoubleAnimation anim = new DoubleAnimation();
        anim.From = 0;
        anim.To = 300;
        anim.Duration = TimeSpan.FromMilliseconds(500);
        anim.EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseInOut, Power = 5 };
        TranslateTransform trans = new TranslateTransform();
        adduser_btn.RenderTransform = trans;
        trans.BeginAnimation(TranslateTransform.XProperty, anim);

        UT.anim.RegisterParent(RootGrid, RootBorder);
        UT.anim.AnimParent("zoomout2");
        await Task.Delay(500);
        UT.NavigateTo(typeof(AddUser));

        anim.From = 0;
        anim.To = 0;
        anim.Duration = TimeSpan.FromMilliseconds(500);
        anim.EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseInOut, Power = 5 };
        adduser_btn.RenderTransform = trans;
        trans.BeginAnimation(TranslateTransform.XProperty, anim);
    }
    
    public async void PCname_Click(object sender, RoutedEventArgs e)
    {
        DoubleAnimation anim = new DoubleAnimation();
        anim.From = 0;
        anim.To = 300;
        anim.Duration = TimeSpan.FromMilliseconds(500);
        anim.EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseInOut, Power = 5 };
        TranslateTransform trans = new TranslateTransform();
        pcname_btn.RenderTransform = trans;
        trans.BeginAnimation(TranslateTransform.XProperty, anim);

        UT.anim.RegisterParent(RootGrid, RootBorder);
        UT.anim.AnimParent("zoomout2");
        await Task.Delay(500);
        UT.NavigateTo(typeof(PCname));

        anim.From = 0;
        anim.To = 0;
        anim.Duration = TimeSpan.FromMilliseconds(500);
        anim.EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseInOut, Power = 5 };
        pcname_btn.RenderTransform = trans;
        trans.BeginAnimation(TranslateTransform.XProperty, anim);
    }

    public async void EdgeSet_Click(object sender, RoutedEventArgs e)
    {
        DoubleAnimation anim = new DoubleAnimation();
        anim.From = 0;
        anim.To = 300;
        anim.Duration = TimeSpan.FromMilliseconds(500);
        anim.EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseInOut, Power = 5 };
        TranslateTransform trans = new TranslateTransform();
        edgeset_btn.RenderTransform = trans;
        trans.BeginAnimation(TranslateTransform.XProperty, anim);

        UT.anim.RegisterParent(RootGrid, RootBorder);
        UT.anim.AnimParent("zoomout2");
        await Task.Delay(500);
        UT.NavigateTo(typeof(Edge));

        anim.From = 0;
        anim.To = 0;
        anim.Duration = TimeSpan.FromMilliseconds(500);
        anim.EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseInOut, Power = 5 };
        edgeset_btn.RenderTransform = trans;
        trans.BeginAnimation(TranslateTransform.XProperty, anim);
    }

    public async void WinDefSet_Click(object sender, RoutedEventArgs e)
    {
        DoubleAnimation anim = new DoubleAnimation();
        anim.From = 0;
        anim.To = 300;
        anim.Duration = TimeSpan.FromMilliseconds(500);
        anim.EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseInOut, Power = 5 };
        TranslateTransform trans = new TranslateTransform();
        windefset_btn.RenderTransform = trans;
        trans.BeginAnimation(TranslateTransform.XProperty, anim);

        UT.anim.RegisterParent(RootGrid, RootBorder);
        UT.anim.AnimParent("zoomout2");
        await Task.Delay(500);
        UT.NavigateTo(typeof(WinDef));

        anim.From = 0;
        anim.To = 0;
        anim.Duration = TimeSpan.FromMilliseconds(500);
        anim.EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseInOut, Power = 5 };
        windefset_btn.RenderTransform = trans;
        trans.BeginAnimation(TranslateTransform.XProperty, anim);
    }

    public async Task applylang()
    {
        pcname_txt.Text = await UT.GetLang("pcname");
        pcname_desc.Text = await UT.GetLang("descpcname");
        pcname_btn.Content = await UT.GetLang("change");
        adminset_txt.Text = await UT.GetLang("admin");
        adminset_desc.Text = await UT.GetLang("descadmin");
        adminset_btn.Content = await UT.GetLang("set");
        adduser_txt.Text = await UT.GetLang("adduser");
        adduser_desc.Text = await UT.GetLang("descadduser");
        adduser_btn.Content = await UT.GetLang("create");
        auset_txt.Text = await UT.GetLang("adminset");
        auset_desc.Text = await UT.GetLang("descadminset");
        auset_btn.Content = await UT.GetLang("open");
        camoverena_txt.Text = await UT.GetLang("camoverena");
        camoverena_desc.Text = await UT.GetLang("desccamoverena");
        camoverena_btn.Content = await UT.GetLang("enable");
        verbstatena_txt.Text = await UT.GetLang("verbstatena");
        verbstatena_desc.Text = await UT.GetLang("descverbstatena");
        verbstatena_btn.Content = await UT.GetLang("enable");
        edgeset_txt.Text = await UT.GetLang("edgeset");
        edgeset_desc.Text = await UT.GetLang("descedgeset");
        edgeset_btn.Content = await UT.GetLang("open");
        windefset_txt.Text = await UT.GetLang("windefset");
        windefset_desc.Text = await UT.GetLang("descwindefset");
        windefset_btn.Content = await UT.GetLang("open");
    }

    public async Task CheckBTN(bool check)
    {
        if (check)
        {
            await UT.Check();
        }
        if (UTdata.Admin == true) adminset.IsEnabled = false;
        else adminset.IsEnabled = true;
        if(UTdata.CamOver == true) camoverena.IsEnabled = false;
        else camoverena.IsEnabled = true;
        if(UTdata.VerbStat == true) verbstatena.IsEnabled = false;
        else verbstatena.IsEnabled = true;
    }

    public async void Init(object sender, EventArgs e)
    {
        applylang();
        await CheckBTN(false);
    }

    public async void InitAnim(object sender, RoutedEventArgs e)
    {
        foreach (UIElement element in RootStack.Children)
        {
            element.Visibility = Visibility.Hidden;
        }

        await UT.UnDeployBack();

        await CheckBTN(false);

        foreach (UIElement element in RootStack.Children)
        {
            element.Visibility = Visibility.Visible;
            DoubleAnimation opacityAnimation = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromSeconds(0.5),
                EasingFunction = new CubicEase { EasingMode = EasingMode.EaseOut }
            };

            DoubleAnimation translateAnimation = new DoubleAnimation
            {
                From = 30,
                To = 0,
                Duration = TimeSpan.FromSeconds(0.5),
                EasingFunction = new CubicEase { EasingMode = EasingMode.EaseOut }
            };

            TranslateTransform transform = new TranslateTransform();
            element.RenderTransform = transform;

            element.BeginAnimation(UIElement.OpacityProperty, opacityAnimation);
            transform.BeginAnimation(TranslateTransform.YProperty, translateAnimation);

            await Task.Delay(50);
        }
    }

    public Customize(DashboardViewModel viewModel)
    {
        ViewModel = viewModel;

        InitializeComponent();
    }

    public async void adminset_Click(object sender, RoutedEventArgs e)
    {
        if (UT.DialogQShow(await UT.GetLang("admin"), "admin.png"))
        {
            await UT.waitstatus.open(await UT.GetLang("wait.set"), "admin.png");
            await UT.RunMin("net", $"localgroup {UTdata.AdminsName} /add \"{UTdata.User}\"");
            await Task.Delay(1000);
            await UT.waitstatus.open(await UT.GetLang("wait.check"), "check.png");
            await CheckBTN(true);
            await UT.waitstatus.close();
            if (!adminset.IsEnabled)
            {
                UT.DialogIShow(await UT.GetLang("done"), "yes.png");
            }
            else
            {
                UT.DialogIShow(await UT.GetLang("failed"), "no.png");
            }
        }
    }
    
    public async void camover_Click(object sender, RoutedEventArgs e)
    {
        if (UT.DialogQShow(await UT.GetLang("camoverena"), "camera.png"))
        {
            await UT.waitstatus.open(await UT.GetLang("wait.enable"), "camera.png");
            await UT.RunMin("reg", "add \"HKLM\\SOFTWARE\\Microsoft\\OEM\\Device\\Capture\" /v \"NoPhysicalCameraLED\" /t REG_DWORD /d \"1\" /f");
            await Task.Delay(1000);
            await UT.waitstatus.open(await UT.GetLang("wait.check"), "check.png");
            await CheckBTN(true);
            await UT.waitstatus.close();
            if (!camoverena.IsEnabled)
            {
                UT.DialogIShow(await UT.GetLang("done"), "yes.png");
            }
            else
            {
                UT.DialogIShow(await UT.GetLang("failed"), "no.png");
            }
        }
    }

    public async void verbstatena_Click(object sender, RoutedEventArgs e)
    {
        if (UT.DialogQShow(await UT.GetLang("verbstatena"), "verbose.png"))
        {
            await UT.waitstatus.open(await UT.GetLang("wait.enable"), "verbose.png");
            await UT.RunMin("reg", "add \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v \"VerboseStatus\" /t REG_DWORD /d \"1\" /f");
            await Task.Delay(1000);
            await UT.waitstatus.open(await UT.GetLang("wait.check"), "check.png");
            await CheckBTN(true);
            await UT.waitstatus.close();
            if (!verbstatena.IsEnabled)
            {
                UT.DialogIShow(await UT.GetLang("done"), "yes.png");
            }
            else
            {
                UT.DialogIShow(await UT.GetLang("failed"), "no.png");
            }
        }
    }
}
