using CakeManager.MyFaker;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities
{
    /// <summary>
    /// Describe a client for shop
    /// </summary>
    [Table("client")]
    public class Client : EntityBase
    {
        #region Attributes
        private String name;
        private String phone;
        private String mail;
        private Int32 address;
        private Int32 shop;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor with arguments
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="mail"></param>
        public Client(String name, String phone, String mail)
        {
            this.name = name;
            this.phone = phone;
            this.mail = mail;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public Client()
        {

        }
        #endregion

        #region Properties
        /// <summary>
        /// Define or return a name for client
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
        /// Define or return a phone for client
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
        /// Define or return a mail for client
        /// </summary>
        [Column("mail")]
        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
                this.OnPropertyChanged("Mail");
            }
        }
        /// <summary>
        /// Define or return a address for client
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
        /// Define or return a shop for client
        /// </summary>
        [Column("shopId")]
        public Int32 ShopId
        {
            get
            {
                return shop;
            }

            set
            {
                shop = value;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Load single one item random
        /// </summary>
        /// <returns></returns>
        public new Client LoadSingleItem()
        {
            Client result = new Client();
            result.Id = Faker.Number.RandomNumber();
            result.Name = Faker.Name.FullName();
            result.Phone = Faker.Number.RandomNumber().ToString();
            return result;
        }
        /// <summary>
        /// Load multiple items random
        /// </summary>
        /// <returns></returns>
        public new List<Client> LoadMultipleItem()
        {
            List<Client> result = new List<Client>();
            for (int i = 0; i < Faker.Number.RandomNumber(3, 20); i++)
            {
                result.Add(LoadSingleItem());
            }
            return result;
        }
        #endregion
    }
}
