namespace Northwind_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 供應商
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 供應商()
        {
            產品資料 = new HashSet<產品資料>();
        }

        [Key]
        public int 供應商編號 { get; set; }

        [Column("供應商")]
        [Display(Name ="供應商")]
        [Required]
        [StringLength(40)]
        public string 供應商1 { get; set; }

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

        public string 首頁 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<產品資料> 產品資料 { get; set; }
    }
}
