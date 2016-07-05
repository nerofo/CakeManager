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
    public class Provider : Address
    {
        #region Attributes
        private String name;
        private String phone;
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
            this.id = 1;
            this.Name = "Coucou";
            this.Phone = "0299874125";
            this.Street = "2 rue des dauphin";
            this.PostalCode = 35000;
            this.City = "Rennes";
            this.Country = "FRANCE";
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
        #endregion

        #region Methods
        #endregion
    }
}
