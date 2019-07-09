namespace Northwind_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 員工
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 員工()
        {
            訂貨主檔 = new HashSet<訂貨主檔>();
        }

        [Key]
        public int 員工編號 { get; set; }

        [Required]
        [StringLength(20)]
        public string 姓名 { get; set; }

        [Required]
        [StringLength(10)]
        public string 名 { get; set; }

        [StringLength(30)]
        public string 職稱 { get; set; }

        [StringLength(25)]
        public string 稱呼 { get; set; }

        public DateTime? 出生日期 { get; set; }

        public DateTime? 雇用日期 { get; set; }

        [StringLength(60)]
        public string 地址 { get; set; }

        [StringLength(15)]
        public string 城市 { get; set; }

        [StringLength(15)]
        public string 行政區 { get; set; }

        [StringLength(10)]
        public string 區域號碼 { get; set; }

        [StringLength(15)]
        public string 國家地區 { get; set; }

        [StringLength(24)]
        public string 電話號碼 { get; set; }

        [StringLength(4)]
        public string 內部分機號碼 { get; set; }

        [StringLength(255)]
        public string 相片 { get; set; }

        public string 附註 { get; set; }

        public int? 主管 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<訂貨主檔> 訂貨主檔 { get; set; }
    }
}
