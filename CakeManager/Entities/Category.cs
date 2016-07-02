using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities
{
    /// <summary>
    /// Describe a category for product
    /// </summary>
    public class Category : EntityBase
    {
        #region Attributes
        private String name;
        private Category parentCategory;
        private List<Product> product;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor with arguments
        /// </summary>
        /// <param name="name"></param>
        /// <param name="product"></param>
        /// <param name="parentCategory"></param>
        public Category(String name, List<Product> product, Category parentCategory = null)
        {
            this.name = name;
            this.product = product;
            this.parentCategory = parentCategory;
            this.product = new List<Product>();
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public Category()
        {
            this.product = new List<Product>();
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        #endregion
    }
}
