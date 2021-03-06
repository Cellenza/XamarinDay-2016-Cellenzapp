﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Cellenzapp.Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Cellenzapp.Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var assembly = typeof(Cellenzapp.Forms.Views.SettingsPage).GetTypeInfo().Assembly;
            foreach(var res in assembly.GetManifestResourceNames())
                System.Diagnostics.Debug.WriteLine("found resource: " + res);



            MainPage = new Cellenzapp.Forms.Views.RootPage();
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
