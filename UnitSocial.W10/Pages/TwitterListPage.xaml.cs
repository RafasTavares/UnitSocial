//---------------------------------------------------------------------------
//
// <copyright file="TwitterListPage.xaml.cs" company="Microsoft">
//    Copyright (C) 2015 by Microsoft Corporation.  All rights reserved.
// </copyright>
//
// <createdOn>2/16/2016 11:24:37 AM</createdOn>
//
//---------------------------------------------------------------------------

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml;
using AppStudio.DataProviders.Twitter;
using UnitSocial.Sections;
using UnitSocial.ViewModels;
using AppStudio.Uwp;

namespace UnitSocial.Pages
{
    public sealed partial class TwitterListPage : Page
    {
        public TwitterListPage()
        {
            this.ViewModel = ListViewModel.CreateNew(Singleton<TwitterConfig>.Instance);

            this.InitializeComponent();
            new Microsoft.ApplicationInsights.TelemetryClient().TrackPageView(this.GetType().FullName);
        }

        public ListViewModel ViewModel { get; set; }


        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            await this.ViewModel.LoadDataAsync();
            base.OnNavigatedTo(e);
        }

    }
}
