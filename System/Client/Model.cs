namespace System.Client
{
    using System.Collections.Generic;
     /* cliente pode ser dono de endereços */
    public class Model : Address.Owner.Interface
    {
        /* cliente pode ter endereços */
        public IEnumerable<Address.Model> Addresses { get; set; }
    }
}
