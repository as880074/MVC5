namespace Northwind_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 客戶
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 客戶()
        {
            訂貨主檔 = new HashSet<訂貨主檔>();
        }

        [Key]
        [StringLength(5)]
        public string 客戶編號 { get; set; }

        [Required]
        [StringLength(40)]
        public string 公司名稱 { get; set; }

        [StringLength(30)]
        public string 連絡人 { get; set; }

        [StringLength(30)]
        public string 連絡人職稱 { get; set; }

        [StringLength(60)]
        public string 地址 { get; set; }

        [StringLength(15)]
        public string 城市 { get; set; }

        [StringLength(15)]
        public string 行政區 { get; set; }

        [StringLength(10)]
        public string 郵遞區號 { get; set; }

        [StringLength(15)]
        public string 國家地區 { get; set; }

        [StringLength(24)]
        public string 電話 { get; set; }

        [StringLength(24)]
        public string 傳真電話 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<訂貨主檔> 訂貨主檔 { get; set; }
    }
}
