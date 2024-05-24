using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eflyer.Business.Exceptions
{
    public class EntityFileNotFoundException : Exception
    {
        public string PropertyName { get; set; }

        public EntityFileNotFoundException(string propertyName, string? message) : base(message)
        {
            PropertyName = propertyName;
        }
    }
}
