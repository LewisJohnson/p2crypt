namespace UiTest.Views
{
    using System.Windows;

    public partial class MainWindow
    {
        public MainWindow()
		{
			this.InitializeComponent();
			this.Loaded += this.OnLoaded;
		}

		private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
		{
            //Might need
		}


        /* Sorry for breaking MVVM. 
         * But I need netowrk stuff to implement properly
         */
        private void Contact_OnClick(object sender, RoutedEventArgs e)
        {
            var chatwin = new ChatWindow();

            chatwin.InitializeComponent();
            chatwin.Show();
        }
    }
}
