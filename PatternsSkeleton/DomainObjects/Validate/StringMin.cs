using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects.Validate
{
    public class StringMin : IValidate
    {
        public void Validate(string str)
        {
            if(String.IsNullOrEmpty(str) || str.Length < 2)
                 throw  new Exception("Min length for string is 2");
          
        }
    }
}
