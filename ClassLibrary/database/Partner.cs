//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partner()
        {
            this.PartnerSaleHistory = new HashSet<PartnerSaleHistory>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int typeOfPartnerId { get; set; }
        public string legalAddress { get; set; }
        public string tin { get; set; }
        public string director { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public int rating { get; set; }

        [NotMapped]
        public int discountPercentage { get; set; }
    
        public virtual TypeOfPartner TypeOfPartner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerSaleHistory> PartnerSaleHistory { get; set; }
    }
}
