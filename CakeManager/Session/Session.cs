using CakeManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Session
{
    public class Session
    {
        private static Shop shop;

        public static Shop Shop
        {
            get
            {
                if (shop == null)
                    shop = new Shop();
                return shop;
            }
            set
            {
                shop = value;
            }
        }
    }
}
