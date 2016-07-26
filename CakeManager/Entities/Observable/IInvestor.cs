using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Entities.Observable
{
    public interface IInvestor
    {
        void Update(Object toSee);
    }
}
