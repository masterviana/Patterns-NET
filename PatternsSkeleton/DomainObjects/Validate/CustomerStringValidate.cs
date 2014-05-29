using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects.Validate
{
    public class CustomerStringValidate : IValidate
    {
        private readonly List<IValidate> _validateList;

        public CustomerStringValidate()
        {
            _validateList = new List<IValidate>
            {
                new StringMax(), 
                new StringMin()
            };
        }

        public void Validate(string str)
        {
            foreach (IValidate validate in _validateList)
            {
                validate.Validate(str);
            }
        }
    }
}
