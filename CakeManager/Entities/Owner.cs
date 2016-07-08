using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities
{
    /// <summary>
    /// Describe a owner for shop
    /// </summary>
    [Table("owner")]
    public class Owner : EntityBase
    {
        #region Attributes
        private String name;
        private String firstname;
        private Int32 address;
        private Int32 shopId;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for owner
        /// </summary>
        public Owner()
        {

        }
        /// <summary>
        /// Constructor with arguments
        /// </summary>
        /// <param name="name"></param>
        /// <param name="firstname"></param>
        public Owner(String name, String firstname)
        {
            this.name = name;
            this.firstname = firstname;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Define or return a name for provider
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
        /// Define or return a firstname for provider
        /// </summary>
        [Column("firstname")]
        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
                this.OnPropertyChanged("Firstname");
            }
        }
        /// <summary>
        /// Define or return a address for owner
        /// </summary>
        [Column("addressId")]
        public Int32 AddressId
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        /// <summary>
        /// Define or return a shop for owner
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
        #endregion
    }
}
