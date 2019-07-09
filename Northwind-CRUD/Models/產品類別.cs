namespace Northwind_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 產品類別
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 產品類別()
        {
            產品資料 = new HashSet<產品資料>();
        }

        [Key]
        public int 類別編號 { get; set; }

        [Required]
        [StringLength(15)]
        public string 類別名稱 { get; set; }

        public string 說明 { get; set; }

        [Column(TypeName = "image")]
        public byte[] 圖片 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<產品資料> 產品資料 { get; set; }
    }
}
