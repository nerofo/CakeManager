using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities
{
    /// <summary>
    /// Describe a owner for shop
    /// </summary>
    public class Owner : Address
    {
        #region Attributes
        private String name;
        private String firstname;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
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
        #endregion

        #region Methods
        #endregion
    }
}
