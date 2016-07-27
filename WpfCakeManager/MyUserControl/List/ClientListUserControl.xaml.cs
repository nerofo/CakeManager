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
using CakeManager.Entities;
using System.Collections.ObjectModel;
using CakeManager.Database;
using CakeManager.Enums;
using CakeManager.Session;

namespace WpfCakeManager.MyUserControl.List
{
    /// <summary>
    /// Logique d'interaction pour ClientUserControl.xaml
    /// </summary>
    public partial class ClientListUserControl : BaseUserControl
    {
        private ObservableCollection<Client> clients;
        private MySQLManager<Client> clientManager;

        public ObservableCollection<Client> Clients
        {
            get { return clients; }
            set { clients = value; this.OnPropertyChanged("Clients"); }
        }

        public ClientListUserControl()
        {
            InitializeComponent();
            this.clients = new ObservableCollection<Client>();
            this.clientManager = new MySQLManager<Client>(DataConnectionResource.LOCALMYQSL);
            this.ListClientL.ItemsSource = this.clients;
        }

        public void LoadItems()
        {
            List<Client> items = this.clientManager.GetListByWhere("client", "shopId", Session.Shop.Id);
            this.clients.Clear();
            foreach (var item in items)
            {
                this.clients.Add(item);
            }
        }
    }
}
