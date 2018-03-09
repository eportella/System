namespace System.Address
{
    using System.Collections.Generic;

    public class Model
    {
        /* na minha visão se endereço é uma entidade fraca eu simplemente não represento os donos aqui porque nunca vou precisar começar nada partindo de endereço */
        public IEnumerable<Owner.Interface> Owners { get; set; }
    }
}
