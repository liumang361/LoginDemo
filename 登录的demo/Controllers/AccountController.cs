using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            // 如果是登录状态，则条转到个人主页
            if (Session["Username"] != null)
            {
                return RedirectToAction("Show");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel m,string returnUrl)
        {
            if (m.Name == "a" && m.Password == "a")
            {

                //创建身份验证票证，即转换为“已登录状态”
                FormsAuthentication.SetAuthCookie(m.Name, false);
                //存入Session
                Session["Username"] = m.Name;

                //如果是跳转过来的，则返回上一页面
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    //用户个人主页
                    return RedirectToAction("Show");
                }
            }
            else
            {
                ViewData["Tip"] = "用户名或密码有误！";
                return View("Index");
            }
        }

        [Authorize]
        public ActionResult Show()
        {
            return View();

        }


        [Authorize]
        [HttpGet]
        public ActionResult Logout()
        {
            //取消Session会话
            Session.Abandon();
            //删除Forms验证票证
            FormsAuthentication.SignOut();

            return RedirectToAction("Index");
        }
    }
}