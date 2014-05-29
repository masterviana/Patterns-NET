using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects.Validate
{
    public class StringMax : IValidate
    {
        public void Validate(string str)
        {
           if (String.IsNullOrEmpty(str) || str.Length > 50)
               throw  new Exception("Max lenth is 50. ");
        }
    }
}
