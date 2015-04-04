using System.Windows;
using MahApps.Metro;
using UiTest.Resources.Settings;


namespace UiTest
{


    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App
    {

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Application.Startup" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.StartupEventArgs" /> that contains the event data.</param>
        /// <param name="e">Check <see cref="http://mahapps.com/guides/styles.html" /> to see stylesk.</param>
        /// <para> WARNING: If the accent or theme is spelt incorrectly this will be thrown; System.NullReferenceException was unhandled. Object reference not set to an instance of an object. *Do not get caught out!* </para>
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
