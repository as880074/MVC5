using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind_CRUD.Models;

namespace Northwind_CRUD.Controllers
{
    public class EmployeesController : Controller
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

        // GET: Employees
        public ActionResult Index()
        {
            return View(_db.供應商s.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]   // 避免 CSRF攻擊，請配合檢視畫面 Html.BeginForm()表單裡的「@Html.AntiForgeryToken()」這一列程式
        public ActionResult Create(供應商 _Employee)
        {

            if (ModelState.IsValid)
            {
                _db.供應商s.Add(_Employee);
                _db.SaveChanges();
                //return Content(" 新增一筆記錄，成功！");    // 新增成功後，出現訊息（字串）。
                return RedirectToAction("index");
            }
            else
            {   // 需搭配檢視畫面的 @Html.ValidationSummary(true)
                // 並且 return View() 回到原本的新增畫面上，顯示錯誤訊息！
                ModelState.AddModelError("", "輸入資料有誤！");
            }
            return View();

        }
        public ActionResult Delete(int? id = 1)
        {
            if (id == null)
            {   // 沒有輸入編號（id），就會報錯 - Bad Request
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            // 使用上方 Details動作的程式，先列出這一筆的內容，給使用者確認
            供應商 cm = _db.供應商s.Find(id);

            if (cm == null)
            {   // 找不到這一筆記錄
                return HttpNotFound();
            }
            else
            {
                return View(cm);
            }
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]   //避免 CSRF攻擊，
        public ActionResult DeleteConfirm(int id)
        {
            if (ModelState.IsValid)   // ModelState.IsValid，通過表單驗證（Server-side validation）需搭配 Model底下類別檔的 [驗證]
            {
                供應商 em = _db.供應商s.Find(id);
                _db.供應商s.Remove(em);
                _db.SaveChanges();
                //return Content(" 刪除一筆記錄，成功！");    // 刪除成功後，出現訊息（字串）。
                return RedirectToAction("index");
            }
            else
            {   // 搭配 ModelState.IsValid，如果驗證沒過，就出現錯誤訊息。
                ModelState.AddModelError("Value1", " 刪除失敗 ");

                return View();   // 將錯誤訊息，返回並呈現在「刪除」的檢視畫面上
            }
        }
        public ActionResult Edit(int? id)    // 網址 
        {
            if (id == null)
            {   // 沒有輸入文章編號（ID），就會報錯 - Bad Request
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            供應商 em = _db.供應商s.Find(id.ToString());
            return View(em);   // 把這一筆記錄呈現出來。   
        }


        //== 修改（更新），回寫資料庫 ===============
        [HttpPost]
        [ValidateAntiForgeryToken]   // 避免 CSRF攻擊，

        //public ActionResult Edit([Bind(Include = "UserId, UserName, UserSex, UserBirthDay, UserMobilePhone, UserApproved, DepartmentId")]UserTable2 _userTable)
        public ActionResult Edit(供應商 _Employee)
        {
            if (_Employee == null)
            {   // 沒有輸入內容，就會報錯 - Bad Request
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            if (ModelState.IsValid)
            {
                _db.Entry(_Employee).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return Content(" 更新失敗！！更新失敗！！ ");
            }
        }

        public ActionResult Details(string id)
        {
            if (id == null)
            {   // 沒有輸入編號（id），就會報錯 - Bad Request
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            // 使用上方 Details動作的程式，先列出這一筆的內容，給使用者確認
            客戶 cm = _db.客戶s.Find(id);

            if (cm == null)
            {   // 找不到這一筆記錄
                return HttpNotFound();
            }
            else
            {
                return View(cm);
            }
        }


    }
}