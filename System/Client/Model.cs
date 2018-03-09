namespace System.Client
{
    using System.Collections.Generic;
    public class Model : Address.Owner.Interface
    {
        public IEnumerable<Address.Model> Addresses { get; set; }
    }
}
