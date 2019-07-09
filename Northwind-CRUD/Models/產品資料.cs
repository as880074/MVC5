namespace Northwind_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 產品資料
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 產品資料()
        {
            訂貨明細 = new HashSet<訂貨明細>();
        }

        [Key]
        public int 產品編號 { get; set; }

        [Required]
        [StringLength(40)]
        public string 產品 { get; set; }

        public int? 供應商編號 { get; set; }

        public int? 類別編號 { get; set; }

        [StringLength(20)]
        public string 單位數量 { get; set; }

        [Column(TypeName = "money")]
        public decimal? 單價 { get; set; }

        public short? 庫存量 { get; set; }

        public short? 已訂購量 { get; set; }

        public short? 安全存量 { get; set; }

        public bool 不再銷售 { get; set; }

        public virtual 供應商 供應商 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<訂貨明細> 訂貨明細 { get; set; }

        public virtual 產品類別 產品類別 { get; set; }
    }
}
