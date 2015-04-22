using System;
using System.ComponentModel;
using System.Windows;
using MahApps.Metro.Controls.Dialogs;
using UiTest.Resources.Settings;

namespace UiTest.Views
{



    public partial class MainWindow
    {

        public MainWindow()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }


        private async void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            if (/*Settings.Default.FirstRun*/ true)
            {

                await this.ShowMessageAsync(
                    UiTest.Resources.Resources.WELCOME,
                    UiTest.Resources.Resources.FIRST_LAUNCH_WELCOME);
            }

            Settings.Default.FirstRun = false;
            Settings.Default.Save();
        }


        /* Sorry for breaking MVVM. 
         * But I need netowrk stuff to implement properly
         */
        private void Contact_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new ChatPage());
        }

        private void MetroWindow_Closing(object sender, CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
