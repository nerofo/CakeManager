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
        private Int32 shopId;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor with arguments
        /// </summary>
        /// <param name="name"></param>
        /// <param name="product"></param>
        /// <param name="parentCategory"></param>
        public Category(String name, List<Product> product)
        {
            this.Name = name;
        }
        /// <summary>
        /// Constructor for category
        /// </summary>
        public Category()
        {
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
        //public int Shop_Id { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
