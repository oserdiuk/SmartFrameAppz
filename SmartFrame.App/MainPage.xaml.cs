using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SmartFrame.App.AuthorizationServiceReference;
using static Windows.Storage.ApplicationData;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SmartFrame.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void LogibBtn_Click(object sender, RoutedEventArgs e)
        {
            var localSettings = Current.LocalSettings;
            var loginSetting = localSettings.Values["login"];
            if (loginSetting == null)
            {
                AuthServiceClient client = new AuthServiceClient();
                var user = await client.LoginAsync(UserNameTb.Text, PasswordTb.Password);
                await client.CloseAsync();
                if (user == null)
                {
                    ErrorTb.Text = "Invalid password or name.";
                    return;
                }
                loginSetting = user.UserName;
            }
            this.Frame.Navigate(typeof(SettingsPage));
        }
    }
}
