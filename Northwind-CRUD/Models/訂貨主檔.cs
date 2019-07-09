namespace Northwind_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 訂貨主檔
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 訂貨主檔()
        {
            訂貨明細 = new HashSet<訂貨明細>();
        }

        [Key]
        public int 訂單號碼 { get; set; }

        [StringLength(5)]
        public string 客戶編號 { get; set; }

        public int? 員工編號 { get; set; }

        public DateTime? 訂單日期 { get; set; }

        public DateTime? 要貨日期 { get; set; }

        public DateTime? 送貨日期 { get; set; }

        public int? 送貨方式 { get; set; }

        [Column(TypeName = "money")]
        public decimal? 運費 { get; set; }

        [StringLength(40)]
        public string 收貨人 { get; set; }

        [StringLength(60)]
        public string 送貨地址 { get; set; }

        [StringLength(15)]
        public string 送貨城市 { get; set; }

        [StringLength(15)]
        public string 送貨行政區 { get; set; }

        [StringLength(10)]
        public string 送貨郵遞區號 { get; set; }

        [StringLength(15)]
        public string 送貨國家地區 { get; set; }

        public virtual 客戶 客戶 { get; set; }

        public virtual 員工 員工 { get; set; }

        public virtual 貨運公司 貨運公司 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<訂貨明細> 訂貨明細 { get; set; }
    }
}
