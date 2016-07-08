using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities
{
    /// <summary>
    /// Describe a product for shop
    /// </summary>
    [Table("product")]
    public class Product : EntityBase
    {
        #region Attributes
        private String name;
        private Decimal price;
        private Int32 category;
        private Int32 shopId;
        private Decimal quantity;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor with arguments
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        public Product(Int32 id, String name, Decimal price, Decimal quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        /// <summary>
        /// Constructor for product
        /// </summary>
        public Product()
        {

        }
        #endregion

        #region Properties
        /// <summary>
        /// Define or return a name for product
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
        /// Define or return a name for product
        /// </summary>
        [Column("categoryId")]
        public Int32 CategoryId
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
                this.OnPropertyChanged("Name");
            }
        }
        /// <summary>
        /// Define or return a price for product
        /// </summary>
        [Column("price")]
        public Decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
                this.OnPropertyChanged("Price");
            }
        }
        /// <summary>
        /// Define or return a quantity for product
        /// </summary>
        [Column("quantity")]
        public Decimal Quantity
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
        /// Define or return a shop for product
        /// </summary>
        [Column("shopId")]
        public Int32 ShopId
        {
            get
            {
                return shopId;
            }

            set
            {
                shopId = value;
            }
        }
        #endregion

        #region Methods
        override
        public String ToString()
        {
            return this.id + "-" + this.name;
        }
        #endregion
    }
}
