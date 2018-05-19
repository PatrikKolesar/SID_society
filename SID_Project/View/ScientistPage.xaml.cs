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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SID_Project.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ScientistPage : Page
    {
        public ScientistPage()
        {
            this.InitializeComponent();
        }

        private void ButtonClickLogin(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LoginPage));
        }

        private void ButtonClickPopUp(object sender, RoutedEventArgs e)
        {
            ppup.IsOpen = true;
           
        }

        private void ButtonClickPopUp1(object sender, RoutedEventArgs e)
        {
            ppup1.IsOpen = true;

        }

        private void ButtonClickPopUp2(object sender, RoutedEventArgs e)
        {
            ppup2.IsOpen = true;

        }

        private void ButtonClickPopUp3(object sender, RoutedEventArgs e)
        {
            ppup3.IsOpen = true;

        }
        private void ButtonClickPopUpClose(object sender, RoutedEventArgs e)
        {
            ppup.IsOpen = false;
            ppup1.IsOpen = false;
            ppup2.IsOpen = false;
            ppup3.IsOpen = false;

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
