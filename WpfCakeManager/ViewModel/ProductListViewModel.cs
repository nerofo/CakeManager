using CakeManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    class ProductListViewModel
    {
        private ProductListView productListView;

        public ProductListViewModel(ProductListView productListView)
        {
            this.productListView = productListView;

            //TODO JEU DE DONNEES A ENLEVER
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "chocolat";
            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "vanille";

            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            this.productListView.ProductListUserControl.LoadItems(products);
        }
    }
}
