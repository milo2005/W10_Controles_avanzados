using ControlesAvanzados.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace ControlesAvanzados
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class GaleriaPage : Page
    {
        public GaleriaPage()
        {
            this.InitializeComponent();
        }

        private ObservableCollection<MenuItem> menuList;

        public ObservableCollection<MenuItem> MenuList 
        {
            get {
                if (menuList == null) {
                    menuList = new ObservableCollection<MenuItem>();

                    MenuItem item = new MenuItem() {Name="Favoritos",Icon= "Favorite" };
                    MenuItem item1 = new MenuItem() { Name = "Halloween", Icon = "Emoji2" };
                    MenuItem item2 = new MenuItem() { Name = "Recientes", Icon = "Camera" };
                    MenuItem item3 = new MenuItem() { Name = "Mapa", Icon = "Map" };
                    MenuItem item4 = new MenuItem() { Name = "Calendario", Icon = "Calendar" };

                    menuList.Add(item);
                    menuList.Add(item1);
                    menuList.Add(item2);
                    menuList.Add(item3);
                    menuList.Add(item4);

                }
                return menuList;
            }
            set { menuList = value; }
        }

        private ObservableCollection<GaleryItem> galery;

        public ObservableCollection<GaleryItem> Galery
        {
            get {
                if (galery == null) {
                    galery = new ObservableCollection<GaleryItem>();

                    GaleryItem item = new GaleryItem() {Date="Hoy", Score=50, Url= "http://static.betazeta.com/www.veoverde.com/wp-content/uploads/2011/07/fotos-gatos-660x350.jpg" };
                    GaleryItem item1 = new GaleryItem() { Date = "Hoy", Score = 50, Url = "http://41.media.tumblr.com/418221b1c9af781a95ad779a29023eda/tumblr_n410tgT56k1tycbfko1_1280.jpg" };
                    GaleryItem item2 = new GaleryItem() { Date = "Hoy", Score = 20, Url = "http://www.sabiask.com/images/Image/perro.jpg" };
                    GaleryItem item3 = new GaleryItem() { Date = "Ayer", Score = 10, Url = "http://www.recreoviral.com/wp-content/uploads/2014/10/ninos-disfrazados-para-halloween-520x272.jpg" };
                    GaleryItem item4 = new GaleryItem() { Date = "Ayer", Score = 80, Url = "http://www.lavozlibre.com/userfiles/2a_decada/image/FOTOS%202013/10%20OCTUBRE%202013/27%20OCTUBRE%202013/halloween.jpg" };
                    GaleryItem item5 = new GaleryItem() { Date = "Ayer", Score = 90, Url = "http://www.furiamag.com/wp-content/uploads/2014/03/04-Peter-Brannon.jpg" };
                    GaleryItem item6 = new GaleryItem() { Date = "Ayer", Score = 10, Url = "http://a2.assets.nationalgeographic.es/soc_photo/20639.600x450.jpg" };
                    GaleryItem item7 = new GaleryItem() { Date = "Miercoles", Score = 30, Url = "http://www.estudiantes.info/ciencias_naturales/images/lobo-nieve.png" };
                    GaleryItem item8 = new GaleryItem() { Date = "Miercoles", Score = 20, Url = "https://i.ytimg.com/vi/S1Qmy-VBkiU/hqdefault.jpg" };
                    GaleryItem item9 = new GaleryItem() { Date = "Lunes", Score = 99, Url = "http://www.sabiask.com/images/Image/perro.jpg" };

                    galery.Add(item);
                    galery.Add(item1);
                    galery.Add(item2);
                    galery.Add(item3);
                    galery.Add(item4);
                    galery.Add(item5);
                    galery.Add(item6);
                    galery.Add(item7);
                    galery.Add(item8);
                    galery.Add(item9);
                }
                return galery;
            }
            set { galery = value; }
        }




        private void showMenu(object sender, RoutedEventArgs e)
        {
            if (split.IsPaneOpen)
                split.IsPaneOpen = false;
            else
                split.IsPaneOpen = true;
            
        }
    }
}
