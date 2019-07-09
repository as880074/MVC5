namespace Northwind_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 貨運公司
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 貨運公司()
        {
            訂貨主檔 = new HashSet<訂貨主檔>();
        }

        [Key]
        public int 貨運公司編號 { get; set; }

        [Required]
        [StringLength(40)]
        public string 貨運公司名稱 { get; set; }

        [StringLength(24)]
        public string 電話 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<訂貨主檔> 訂貨主檔 { get; set; }
    }
}
