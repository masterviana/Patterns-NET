using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects.Validate
{
    public class BlockSqlInjection : IValidate
    {
        public void Validate(string str)
        {
            if (String.IsNullOrEmpty(str)
                   || str.Contains("select") || str.Contains("insert") )
                   throw new Exception("Trying to do some kind of sql injection. Validate our input");
        }
    }
}
