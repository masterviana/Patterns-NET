namespace DomainObjects.Validate
{

    public class StringPreValidadeFactory : IFactory<CustomerStringValidate>
    {
        public CustomerStringValidate Create()
        {
            return new CustomerStringValidate();
        }
    }

    public class BlockSqlValidadeFactory : IFactory<BlockSqlInjection>
    {
        public BlockSqlInjection Create()
        {
            return new BlockSqlInjection();
        }
    }
}
