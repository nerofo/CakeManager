using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities
{
    /// <summary>
    /// Describe a address
    /// </summary>
    public class Address : EntityBase
    {
        #region Attributes
        private String street;
        private Int32 postalCode;
        private String city;
        private String country;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor with arguments
        /// </summary>
        /// <param name="street"></param>
        /// <param name="postalCode"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        public Address(String street, Int32 postalCode, String city, String country)
        {
            this.street = street;
            this.postalCode = postalCode;
            this.city = city;
            this.country = country;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public Address()
        {
            this.Id = 1;
            this.Street = "2 rue des loutres";
            this.PostalCode = 35000;
            this.City = "Rennes";
            this.Country = "FRANCE";
        }
        #endregion

        #region Properties
        /// <summary>
        /// Define or return a postal code for address
        /// </summary>
        public int PostalCode
        {
            get
            {
                return postalCode;
            }

            set
            {
                postalCode = value;
                this.OnPropertyChanged("PostalCode");
            }
        }
        /// <summary>
        /// Define or return a city for address
        /// </summary>
        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
                this.OnPropertyChanged("City");
            }
        }
        /// <summary>
        /// Define or return a country for address
        /// </summary>
        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
                this.OnPropertyChanged("Country");
            }
        }
        /// <summary>
        /// Define or return a street for address
        /// </summary>
        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                street = value;
                this.OnPropertyChanged("Street");
            }
        }
        #endregion

        #region Methods
        #endregion
    }
}
