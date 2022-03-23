using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NotEmpty : Attribute { }


    [AttributeUsage(AttributeTargets.Property)]
    public class NotDuplicated : Attribute { }


    [AttributeUsage(AttributeTargets.Property)]
    public class PropsName : Attribute
    {
        public string Name { get; set; }

        public PropsName(string name)
        {
            Name = name;
        }
    }


    [AttributeUsage(AttributeTargets.Property)]
    public class FormatEmail : Attribute { }


    [AttributeUsage(AttributeTargets.Property)]
    public class FormatDate : Attribute { }
}
