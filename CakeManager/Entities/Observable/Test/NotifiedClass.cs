using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities.Observable.Test
{
    public class NotifiedClass : IInvestor
    {
        private int id;
        private Boolean isSTH;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Boolean IsSTH
        {
            get { return isSTH; }
            set { isSTH = value; }
        }



        public void Update(object toSee)
        {
            Console.WriteLine(toSee);
        }
    }
}
