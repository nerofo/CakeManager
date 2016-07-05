using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities
{
    /// <summary>
    /// Describe a provider for shop
    /// </summary>
    [Table("provider")]
    public class Provider : EntityBase
    {
        #region Attributes
        private String name;
        private String phone;
        private Address address;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor with arguments
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        public Provider(String name, String phone)
        {
            this.name = name;
            this.phone = phone;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public Provider()
        {

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
        /// Define or return a phone for provider
        /// </summary>
        [Column("phone")]
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
                this.OnPropertyChanged("Phone");
            }
        }
        /// <summary>
        /// Define or return a address for provider
        /// </summary>
        [Column("address")]
        public Address Address
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
        #endregion

        #region Methods
        #endregion
    }
}
