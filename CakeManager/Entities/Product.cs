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
        private Category category;
        private Int32 quantity;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor with arguments
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Product(Int32 id, String name, Decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
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
        [Column("category")]
        public Category Category
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
        public Int32 Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                price = value;
                this.OnPropertyChanged("Quantity");
            }
        }
        #endregion

        #region Methods
        #endregion
    }
}
