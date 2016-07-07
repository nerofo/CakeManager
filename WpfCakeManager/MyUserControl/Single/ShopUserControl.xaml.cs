using CakeManager.API;
using CakeManager.Database;
using CakeManager.Entities;
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

namespace WpfCakeManager.MyUserControl.Single
{
    /// <summary>
    /// Logique d'interaction pour AddressUserControl.xaml
    /// </summary>
    public partial class ShopUserControl : BaseUserControl
    {
        private Shop shop;
        private MySQLManager<Shop> database;

        public Shop Shop
        {
            get { return shop; }
            set
            {
                shop = value;
                this.OnPropertyChanged("Shop");
                this.AddressUserControl.Address = shop.Address;
            }
        }

        public ShopUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
