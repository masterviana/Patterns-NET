using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainObjects.Validate;

namespace DomainObjects
{
    /// <summary>
    /// Obrigo quem está a assinar este contrato a seguir este workflow
    /// </summary>
    public abstract class AbsOperationUtils : IOperationUtils
    {

        private readonly IValidate _validadeOnWrite;
        private readonly IValidate _validadeOnRead;
        internal abstract void WriteToImp(string message);
        internal abstract void ReadToImp(string message);


        public AbsOperationUtils()
        {
            _validadeOnWrite = new StringPreValidadeFactory().Create();
            _validadeOnRead = new BlockSqlValidadeFactory().Create();
        }

        public void Write(string message)
        {
            _validadeOnWrite.Validate(message);
             WriteToImp(message);
            
        }

        public void Read( string message)
        {
           _validadeOnRead.Validate(message);
           ReadToImp(message);
        }
    }
}
