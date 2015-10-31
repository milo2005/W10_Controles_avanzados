using ControlesAvanzados.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace ControlesAvanzados
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class EditGalery : Page
    {
        GaleryItem item;
        Frame rootFrame;

        public EditGalery()
        {
            this.InitializeComponent();

            rootFrame = Window.Current.Content as Frame;

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility 
                = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += EditGalery_BackRequested;
        }

        private void EditGalery_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (e.Handled == false)
            {
                e.Handled = true;
                rootFrame.GoBack();
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            item = e.Parameter as GaleryItem;
            date.Text = item.Date;


            ImageBrush brush = new ImageBrush();
            brush.Stretch = Stretch.UniformToFill;

            BitmapImage image = new BitmapImage(new Uri(item.Url));
            brush.ImageSource = image;

            img.Fill = brush;
        }

        private void ok(object sender, RoutedEventArgs e)
        {
            item.Date = date.Text;
            rootFrame.GoBack();
        }
    }

    
}
