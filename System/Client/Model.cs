namespace System.Client
{
    using System.Collections.Generic;
     /* cliente é dono de um endereço */
    public class Model : Address.Owner.Interface
    {
        /* cliente tem um endereço */
        public IEnumerable<Address.Model> Addresses { get; set; }
    }
}
