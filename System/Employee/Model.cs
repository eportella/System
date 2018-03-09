namespace System.Employee
{
    using System.Collections.Generic;
    class Model : Address.Owner.Interface
    {
        public IEnumerable<Address.Model> Addresses { get; set; }
    }
}
