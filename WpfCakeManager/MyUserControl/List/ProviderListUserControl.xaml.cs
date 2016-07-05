using CakeManager.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfCakeManager.MyUserControl.List
{
    /// <summary>
    /// Logique d'interaction pour ProviderListUserControl.xaml
    /// </summary>
    public partial class ProviderListUserControl : BaseUserControl
    {
        private ObservableCollection<Provider> providers;

        public ObservableCollection<Provider> Providers
        {
            get { return providers; }
            set { providers = value; }
        }

        public ProviderListUserControl()
        {
            InitializeComponent();
            this.providers = new ObservableCollection<Provider>();
            this.ListProviderL.ItemsSource = this.providers;
        }

        public void LoadItems(List<Provider> items)
        {
            this.providers.Clear();
            foreach (var item in items)
            {
                this.providers.Add(item);
            }
        }
    }
}
