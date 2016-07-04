using CakeManager.Entities;
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

namespace WpfCakeManager.MyUserControl
{
    /// <summary>
    /// Logique d'interaction pour CategoryUserControl.xaml
    /// </summary>
    public partial class CategoryListUserControl : BaseUserControl
    {
        protected Category category;

        public Category Category
        {
            get { return category; }
            set
            {
                category = value;
                this.OnPropertyChanged("Category");
            }
        }

        public CategoryListUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
