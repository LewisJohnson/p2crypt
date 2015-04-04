using System;
using System.ComponentModel;
using System.Windows;

using UiTest.Resources.Settings;

using MahApps.Metro.Controls.Dialogs;


namespace UiTest.Views
{


    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
            this.Loaded += this.OnLoaded;
        }

        /// <summary>
        /// Called when [loaded].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="routedEventArgs">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
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
        /// <summary>
        /// Handles the OnClick event of the Contact control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private
        void Contact_OnClick(object sender, RoutedEventArgs e)
        {
            var chatwin = new ChatWindow();

            chatwin.InitializeComponent();
            chatwin.Show();
        }

        private void MetroWindow_Closing(object sender, CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
