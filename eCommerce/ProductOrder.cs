//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eCommerce
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductOrder
    {
        public int productId { get; set; }
        public int orderId { get; set; }
        public Nullable<byte> qt { get; set; }
    
        public virtual Eorder Eorder { get; set; }
        public virtual Product Product { get; set; }
    }
}
