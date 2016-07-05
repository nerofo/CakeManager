using CakeManager.Entities;
using CakeManager.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Database
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class FullDb : DbContext
    {
        //#region Singleton
        //private static volatile FullDb instance;
        //private static object syncRoot = new Object();
        //private FullDb() { }
        //public static FullDb Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            lock (syncRoot)
        //            {
        //                if (instance == null)
        //                    instance = new FullDb();
        //            }
        //        }
        //        return instance;
        //    }
        //}
        //#endregion

        public DbSet<Address> DbSetAddress { get; set; }
        public DbSet<Client> DbSetClient { get; set; }
        public DbSet<Category> DbSetCategory { get; set; }
        public DbSet<Order> DbSetOrder { get; set; }
        public DbSet<Owner> DbSetOwner { get; set; }
        public DbSet<Product> DbSetProduct { get; set; }
        public DbSet<Provider> DbSetProvider { get; set; }
        public DbSet<Shop> DbSetShop { get; set; }

        public FullDb(DataConnectionResource dataConnectionResource)
            : base(EnumString.GetStringValue(dataConnectionResource))
        {
            this.Database.CreateIfNotExists();
        }
    }
}
