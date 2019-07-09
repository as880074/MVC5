namespace Northwind_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 訂貨明細
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int 訂單號碼 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int 產品編號 { get; set; }

        [Column(TypeName = "money")]
        public decimal 單價 { get; set; }

        public short 數量 { get; set; }

        public float 折扣 { get; set; }

        public virtual 訂貨主檔 訂貨主檔 { get; set; }

        public virtual 產品資料 產品資料 { get; set; }
    }
}
