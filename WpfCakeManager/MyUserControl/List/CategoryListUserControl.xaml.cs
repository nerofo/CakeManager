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
    public partial class CategoryListUserControl : BaseUserControl
    {
        private ObservableCollection<Category> categories;

        public ObservableCollection<Category> Category
        {
            get { return categories; }
            set { categories = value; this.OnPropertyChanged("Category"); }
        }


        public CategoryListUserControl()
        {
            InitializeComponent();
            this.categories = new ObservableCollection<Category>();
            this.ListCategoryL.ItemsSource = this.categories;
        }

        public void LoadItems(List<Category> items)
        {
            this.categories.Clear();
            foreach (var item in items)
            {
                this.categories.Add(item);
            }
        }
    }
}
