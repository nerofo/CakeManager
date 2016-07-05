using CakeManager.MyFaker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CakeManager.Entities
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public class EntityBase : INotifyPropertyChanged, IFakerLoader<EntityBase>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Attributes
        protected Int32 id;
        #endregion

        #region Property
        /// <summary>
        /// Define or return a id for EntityBase
        /// </summary>
        [Key]
        [Column("id")]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                this.OnPropertyChanged("Id");
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for entitybase
        /// </summary>
        public EntityBase()
        {

        }
        #endregion

        #region Methods
        public void OnPropertyChanged(String name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        /// <summary>
        /// Load one item random
        /// </summary>
        /// <returns></returns>
        public EntityBase LoadSingleItem()
        {
            EntityBase result = new EntityBase();
            result.Id = Faker.Number.RandomNumber();
            return result;
        }
        /// <summary>
        /// Load multiple item random
        /// </summary>
        /// <returns></returns>
        public List<EntityBase> LoadMultipleItems()
        {
            List<EntityBase> result = new List<EntityBase>();
            for (int i = 0; i < Faker.Number.RandomNumber(3, 20); i++)
            {
                result.Add(LoadSingleItem());
            }
            return result;
        }

        #endregion
    }
}
