using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Events
{
    public class ClassWithEvent
    {
        public event EventHandler Handler;
        public event EventHandler<ClassWithEvent> Handler1;

        public int id { get; set; }
        public String name { get; set; }
    }
}
