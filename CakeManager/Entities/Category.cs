using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities
{
    /// <summary>
    /// Describe a category for product
    /// </summary>
    [Table("category")]
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
            this.Name = name;
            this.Product = product;
            this.ParentCategory = parentCategory;
            this.Product = new List<Product>();
        }
        /// <summary>
        /// Constructor for category
        /// </summary>
        public Category()
        {
            this.Product = new List<Product>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Define or return a name
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
            }
        }
        /// <summary>
        /// Define or return a parentcategory
        /// </summary>
        [Column("parentCategory")]
        public Category ParentCategory
        {
            get
            {
                return parentCategory;
            }

            set
            {
                parentCategory = value;
            }
        }
        /// <summary>
        /// Define or return a product
        /// </summary>
        [Column("product")]
        public List<Product> Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }
        #endregion

        #region Methods
        #endregion
    }
}
