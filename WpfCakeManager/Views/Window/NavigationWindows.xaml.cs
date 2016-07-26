using CakeManager.API;
using CakeManager.Database;
using CakeManager.Entities;
using CakeManager.Entities.Observable;
using CakeManager.Entities.Observable.Test;
using CakeManager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfCakeManager.Views;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.Views
{
    /// <summary>
    /// Logique d'interaction pour NavigationWindows1.xaml
    /// </summary>
    public partial class NavigationWindows1 : NavigationWindow
    {
        public NavigationWindows1()
        {
            InitializeComponent();
            //TEST OBSERVATION
            //ObersedClass obs = new ObersedClass();
            //NotifiedClass n1 = new NotifiedClass();
            //NotifiedClass n2 = new NotifiedClass();
            //obs.Attach(n1);
            //obs.Attach(n2);
            //obs.Notify();
            this.NavigationService.Navigate(new ShopListView());
        }

        public async void testApiConnection()
        {
            WebServiceManager<Client> webService = new WebServiceManager<Client>(DataConnectionResource.LOCALAPI);
            Client client1 = new Client().LoadSingleItem();
            Client apiResult;
            //envoi enregistrer client a l'api
            await webService.Post(client1);
            //recuperation d'un client via l'id d'un client
            apiResult = await webService.Get(client1.Id);
        }
    }
}
