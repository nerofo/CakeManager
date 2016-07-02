using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities
{
    /// <summary>
    /// Describe a client for shop
    /// </summary>
    public class Client : Address
    {
        #region Attributes
        private String name;
        private String phone;
        private String mail;
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
        #endregion

        #region Methods
        #endregion
    }
}
