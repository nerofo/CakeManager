using CakeManager.API;
using CakeManager.Database;
using CakeManager.Entities;
using CakeManager.Enums;
using CakeManager.Session;
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
    /// Logique d'interaction pour CategoryUserControl.xaml
    /// </summary>
    public partial class CategoryUserControl : BaseUserControl
    {
        private Category category;
        private MySQLManager<Category> categoryManager;
        private WebServiceManager<Category> categoryWebService;

        public Category Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
                this.OnPropertyChanged("Category");
            }
        }

        public CategoryUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
            this.categoryManager = new MySQLManager<Category>(DataConnectionResource.LOCALMYQSL);
            this.categoryWebService = new WebServiceManager<Category>(DataConnectionResource.LOCALAPI);
        }

        public async void Load(Int32 categoryId)
        {
            if (categoryId != 0)
                this.category = await this.categoryManager.Get(categoryId);
            else
                this.category = new Category();
        }

        public Int32 Update()
        {
            this.category.ShopId = Session.Shop.Id;
            if (this.category.Id == 0)
            {
                //this.address = this.addressWebService.Post(this.address).Result;
                this.category = this.categoryManager.Insert(this.category).Result;
            }
            else
            {

            }
            return this.category.Id;
        }
    }
}
