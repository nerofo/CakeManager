using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities
{
    /// <summary>
    /// Describe a product for shop
    /// </summary>
    public abstract class Product : EntityBase
    {
        #region Attributes
        private String name;
        private Decimal price;
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
        /// Constructor
        /// </summary>
        public Product()
        {

        }
        #endregion

        #region Properties
        /// <summary>
        /// Define or return a name for product
        /// </summary>
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
        /// Define or return a price for product
        /// </summary>
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
        #endregion

        #region Methods
        /// <summary>
        /// Display product with attribute
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.name + " " + this.price + " e";
        }
        #endregion
    }
}
