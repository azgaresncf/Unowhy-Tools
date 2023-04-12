﻿using Wpf.Ui.Common.Interfaces;
using Unowhy_Tools_WPF.ViewModels;

using Unowhy_Tools;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System;

namespace Unowhy_Tools_WPF.Views.Pages;

/// <summary>
/// Interaction logic for Dashboard.xaml
/// </summary>
public partial class PCinfo : INavigableView<DashboardViewModel>
{
    UT.Data UTdata = new UT.Data();

    public DashboardViewModel ViewModel
    {
        get;
    }

    public async void GoBack(object sender, RoutedEventArgs e)
    {
        UT.anim.BackBtnAnim(BackBTN);
        await Task.Delay(150);
        UT.anim.TransitionBack(RootGrid);
        await Task.Delay(200);
        UT.NavigateTo(typeof(Dashboard));
    }

    public void applylang()
    {
        labpnc.Text = UT.GetLang("pcn");
        labuid.Text = UT.GetLang("domuser");
        labmf.Text = UT.GetLang("mfm");
        labsn.Text = UT.GetLang("serial");
        labbv.Text = UT.GetLang("biosversion");
        labwv.Text = UT.GetLang("os");
    }

    public void infoapply()
    {
        string year = "";
        if (UTdata.sn.Contains("IFP2")) year = "(2022)";
        if (UTdata.sn.Contains("IFP1")) year = "(2021)";
        if (UTdata.sn.Contains("IFP0")) year = "(2020)";
        if (UTdata.sn.Contains("IFP9")) year = "(2019)";
        if (UTdata.md.Contains("Y13G012")) year = "(2022)";
        if (UTdata.md.Contains("Y13G011")) year = "(2021)";
        if (UTdata.md.Contains("Y13G010")) year = "(2020)";
        if (UTdata.md.Contains("Y13G002")) year = "(2019)";
        uid.Text = UTdata.UserID;
        pcn.Text = UTdata.HostName;
        mf.Text = UT.GetLine(UTdata.mf, 1).Replace("  ", "") + " " + UT.GetLine(UTdata.md, 1).Replace("  ", "") + " " + year;
        sn.Text = UTdata.sn;
        bv.Text = UTdata.bios;
        wv.Text = UTdata.os;
        if (wv.Text.Contains("11"))
        {
            imgwv.Source = new BitmapImage(new System.Uri("pack://application:,,,/Resources/win11.png"));
        }
        else if (wv.Text.Contains("10"))
        {
            imgwv.Source = new BitmapImage(new System.Uri("pack://application:,,,/Resources/win10.png"));
        }
    }

    public async void InitAnim(object sender, RoutedEventArgs e)
    {
        foreach (UIElement element in RootStack.Children)
        {
            element.Visibility = Visibility.Hidden;
        }

        UT.anim.BackBtnAnimForw(BackBTN);

        await Task.Delay(150);

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
                From = 10,
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

    public PCinfo(DashboardViewModel viewModel)
    {
        ViewModel = viewModel;

        InitializeComponent();

        applylang();
        infoapply();
    }
}
