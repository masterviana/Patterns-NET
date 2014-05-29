using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{
    public interface IOperationUtils
    {
        void Write(String message);
        void Read( String message);
    }
}
