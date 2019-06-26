﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinListView.ViewModels;
using XamarinListView.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinListView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
            var mainViewModel = MainViewModel.GetInstance();
            mainViewModel.Paises = new PaisesViewModel();
            this.MainPage = new NavigationPage(new PaisesPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
