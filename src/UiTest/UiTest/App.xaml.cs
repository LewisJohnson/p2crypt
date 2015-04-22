using System.Windows;
using MahApps.Metro;
using UiTest.Resources.Settings;

namespace UiTest
{

    public partial class App
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            var globaltheme = ThemeManager.DetectAppStyle(Current);

            ThemeManager.ChangeAppStyle(
                Current,
                ThemeManager.GetAccent(Settings.Default.MahAppsAccent),
                ThemeManager.GetAppTheme(Settings.Default.MahAppsTheme));

            base.OnStartup(e);
        }
    }
}
