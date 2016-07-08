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
        private Int32 address;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public Shop()
        {

        }
        /// <summary>
        /// Constructor with arguments
        /// </summary>
        /// <param name="name"></param>
        /// <param name="client"></param>
        /// <param name="owner"></param>
        /// <param name="address"></param>
        /// <param name="product"></param>
        public Shop(String name, Int32 address)
        {
            this.name = name;
            this.address = address;
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
        /// Define or return a address for shop
        /// </summary>
        [Column("addressId")]
        public Int32 Address
        {
            get { return address; }
            set { address = value; this.OnPropertyChanged("Address"); }
        }
        #endregion

        #region Methods

        #endregion
    }
}