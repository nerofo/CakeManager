using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities
{
    /// <summary>
    /// Describe a order for shop
    /// </summary>
    [Table("order")]
    public class Order : EntityBase
    {
        #region Attributes
        private Int32 quantity;
        private Product product;
        private Client client;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor with arguments
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="product"></param>
        /// <param name="client"></param>
        public Order(Int32 quantity, Product product, Client client)
        {
            this.quantity = quantity;
            this.product = product;
            this.client = client;
        }
        /// <summary>
        /// Constructor for order
        /// </summary>
        public Order()
        {

        }
        #endregion

        #region Properties
        /// <summary>
        /// Define or return a quantity for order
        /// </summary>
        [Column("quantity")]
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
                this.OnPropertyChanged("Quantity");
            }
        }
        /// <summary>
        /// Define or return a client for order
        /// </summary>
        [Column("client")]
        public Client Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
                this.OnPropertyChanged("Client");
            }
        }
        /// <summary>
        /// Define or return a product for order
        /// </summary>
        [Column("product")]
        public Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
                this.OnPropertyChanged("Product");
            }
        }
        #endregion

        #region Methods
        #endregion
    }
}
