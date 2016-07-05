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

namespace WpfCakeManager.MyUserControl.List
{
    /// <summary>
    /// Logique d'interaction pour ClientUserControl.xaml
    /// </summary>
    public partial class ProductListUserControl : BaseUserControl
    {
        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; this.OnPropertyChanged("Clients"); }
        }


        public ProductListUserControl()
        {
            InitializeComponent();
            this.products = new ObservableCollection<Product>();
            //this.ListClientL.ItemsSource = this.clients;
        }

        public void LoadItems(List<Product> items)
        {
            this.products.Clear();
            foreach (var item in items)
            {
                this.products.Add(item);
            }
        }
    }
}
