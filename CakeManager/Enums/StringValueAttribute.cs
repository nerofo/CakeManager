using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Enums
{
    public class StringValueAttribute : Attribute
    {
        public String StringValue
        {
            get
            ;
            protected
            set
            ;
        }
        public StringValueAttribute(String value)
        {
            this.StringValue = value;
        }
    }

    public static class EnumString
    {
        public static string GetStringValue(this Enum value)
        {
            return "";
        }
    }
}
