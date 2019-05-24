using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProgrammerAdd.Models;
namespace ProgrammerAdd.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        ConnectionManager cm = new ConnectionManager();
        EncryptionManager em = new EncryptionManager();
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult NewUserMgmt()
        {
            return View();
        }
        public ActionResult LoginInfo()
        {
            return View();
        }
        public ActionResult UploadFilesStudymaterial()
        {
            return View();
        }
        public ActionResult DownloadMgmt() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult DownloadMgmt(string txtfile,string txttype)
        {
            string cmd = "insert into TBL_Down values('" + txtfile + "','"+txttype+"','" + DateTime.Now.ToString() + "')";
            if (cm.ExecuteInsertUpdateOrDelete(cmd) == true)
            {
                Response.Write("<script>alert('File Post')</script>");
            }
            else
            {
                Response.Write("<script>alert('File not Post')</script>");
            }

            return View();
        }
        public ActionResult Notification()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Notification(string txtmsg)
        {
            string cmd = "insert into TBL_Notification values('" + txtmsg + "','" + DateTime.Now.ToString() + "')";
            if (cm.ExecuteInsertUpdateOrDelete(cmd) == true)
            {
                Response.Write("<script>alert('Notification Added')</script>");
            }
            else
            {
                Response.Write("<script>alert('Notification not Added')</script>");
            }
            return View();
        }

        public ActionResult delete()
        {
            if(Request.QueryString["dt"]!=null)
            {
                string userid=Request.QueryString["dt"].ToString();
                string cmd="delete from TBL_Registration where email='"+userid+"'";
                if(cm.ExecuteInsertUpdateOrDelete(cmd) == true)
                {
                    Response.Write("<script>alert('User Remove by admin');window.location.href='/Admin/NewUserMgmt'</script>");
                }
                else
                {
                    Response.Write("<script>alert('User not Remove by admin');window.location.href='/Admin/NewUserMgmt'</script>");
                }
         
            }
            return View();
        }

        public ActionResult Enquiry()

        {
            return View();
        }
        public ActionResult SendSMS()
        {
            return View();
        }
        public ActionResult DiscussionMgmt()
        {
            return View();
        }
        public ActionResult FeedbackMgmt()
        {
            return View();
        }
        public ActionResult LivechatMgmt()
        {
            return View();
        }
         public ActionResult ChangePassword()
        {
            if (Session["aid"] != null)
            {

            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Changepassword(string txtold,string txtnewpass,string txtcpass)
        {
            if (txtnewpass == txtcpass)
            {
                string command = "update TBL_Login set pass='" + em.EncryptData(txtnewpass) + "' where email='" + Session["aid"].ToString()+ "' and pass='" + em.EncryptData(txtold) + "'";
                bool x = cm.ExecuteInsertUpdateOrDelete(command);
                if(x==true)
                {
                    Response.Write("<script>alert('Password change successfully');window.location.herf='/Home/Login'</script>");
                }
                else
                {
                   Response.Write("<script>alert('your password not changed')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Plz confirm password')</script>");
            }
            return View();
        }
         public ActionResult Logout()
         {
             // Destroy the value of session
             Session.Abandon();
             return View();
         }
    }
}
