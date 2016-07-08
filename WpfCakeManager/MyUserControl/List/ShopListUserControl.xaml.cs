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

namespace WpfCakeManager.MyUserControl.List
{
    /// <summary>
    /// Logique d'interaction pour ShopUserControl.xaml
    /// </summary>
    public partial class ShopListUserControl : BaseUserControl
    {
        private ObservableCollection<Shop> shops;
        private MySQLManager<Shop> shopManager;

        public ObservableCollection<Shop> Shop
        {
            get { return shops; }
            set { shops = value; this.OnPropertyChanged("Shop"); }
        }


        public ShopListUserControl()
        {
            InitializeComponent();
            this.shops = new ObservableCollection<Shop>();
            this.shopManager = new MySQLManager<Shop>(DataConnectionResource.LOCALMYQSL);
            this.ListShopL.ItemsSource = this.shops;
        }

        public async void LoadItems()
        {
            List<Shop> shops = await this.shopManager.Get() as List<Shop>;
            this.shops.Clear();
            foreach (var item in shops)
            {
                this.shops.Add(item);
            }
        }
    }
}
