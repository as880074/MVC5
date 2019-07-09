using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind_CRUD.Models;

namespace Northwind_CRUD.Controllers
{
    public class OrderController : Controller
    {
        //建立資料庫
        private NorthwindContext _db = new NorthwindContext();
        //
        // 資料庫一旦開啟連線，用完就得要關閉連線與釋放資源。
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();  //關閉資料庫
            }
            base.Dispose(disposing);
        }
        //

        //如果找不到動作（Action）或是輸入錯誤的動作名稱，一律跳回首頁
        protected override void HandleUnknownAction(string actionName)
        {
            Response.Redirect("Index");
            base.HandleUnknownAction(actionName);
        }

        // GET: Order
        public ActionResult Index()
        {
            return View(_db.訂貨主檔s.ToList());
        }
    }
}