using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities
{
    /// <summary>
    /// Define a Shop
    /// </summary>
    [Table("shop")]
    public class Shop : EntityBase
    {
        #region Attributes
        private String name;
        private List<Client> client;
        private List<Owner> owner;
        private Address address;
        private List<Product> product;
        private List<Category> categories;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public Shop()
        {
            this.client = new List<Client>();
            this.owner = new List<Owner>();
            this.product = new List<Product>();
            this.address = new Address();
            this.categories = new List<Category>();
        }
        /// <summary>
        /// Constructor with arguments
        /// </summary>
        /// <param name="name"></param>
        /// <param name="client"></param>
        /// <param name="owner"></param>
        /// <param name="address"></param>
        /// <param name="product"></param>
        public Shop(String name, List<Client> client, List<Owner> owner, Address address, List<Product> product)
        {
            this.name = name;
            this.client = client;
            this.owner = owner;
            this.address = address;
            this.product = product;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Define or return a name for shop
        /// </summary>
        [Column("name")]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                this.OnPropertyChanged("Name");
            }
        }
        /// <summary>
        /// Define or return a list of owner for shop
        /// </summary>
        [Column("owner")]
        public List<Owner> Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        /// <summary>
        /// Define or return a list of customer for shop
        /// </summary>
        [Column("client")]
        public List<Client> Customers
        {
            get { return client; }
            set { client = value; this.OnPropertyChanged("Client"); }
        }

        /// <summary>
        /// Define or return a address for shop
        /// </summary>
        [Column("address")]
        [ForeignKey("Address_Id")]
        public Address Address
        {
            get { return address; }
            set { address = value; this.OnPropertyChanged("Address"); }
        }
        /// <summary>
        /// Define or return a list of product
        /// </summary>
        [Column("product")]
        public List<Product> Products
        {
            get { return product; }
            set { product = value; this.OnPropertyChanged("Products"); }
        }
        /// <summary>
        /// Define or return a list of category
        /// </summary>
        [Column("category")]
        public List<Category> Categories
        {
            get { return categories; }
            set { categories = value; this.OnPropertyChanged("Categories"); }
        }

        public int Address_Id { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}