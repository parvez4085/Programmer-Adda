using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProgrammerAdd.Models;
using System.Data;

namespace ProgrammerAdd.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        ConnectionManager cm = new ConnectionManager();
        EncryptionManager em = new EncryptionManager();
      
        public ActionResult Index()
        {
            if (Session["uid"] != null)
            {
                string email = Session["uid"].ToString();
               string command=" Select * from TBL_Registration Where email='" + email + "'";
               System.Data.DataTable dt = cm.GetBulksRecord(command);
               if (dt.Rows.Count > 0)
               {
                   string name = dt.Rows[0][0].ToString();
                   string picname = "../Content/Profile/" + dt.Rows[0][7].ToString();
                   ViewBag.nm = name;
                   ViewBag.profile = picname;
                   
               }
               else
               {
                   return RedirectToAction("Login", "Home");
               }
            }
            return View();
        }
        [HttpGet]
        public ActionResult MyProfile()
        {
            
            if (Session["uid"] != null)
            {
                string cmd = "select * from TBL_Registration where email='" + Session["uid"].ToString() + "'";
                DataTable dt = cm.GetBulksRecord(cmd);
                if (dt.Rows.Count > 0)
                {
                    ViewBag.name = dt.Rows[0][0].ToString();
                    ViewBag.lname = dt.Rows[0][1].ToString();
                    ViewBag.mob = dt.Rows[0][2].ToString();
                    ViewBag.currentadd = dt.Rows[0][3].ToString();
                    ViewBag.profession = dt.Rows[0][4].ToString();
                    ViewBag.email = dt.Rows[0][5].ToString();
                    ViewBag.pic = "../Content/Profile/" + dt.Rows[0][7].ToString();
                

                }
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult MyProfile( string txtname,string lastname,string txtmob,string currentadd,string pro,string txtemail)
        {
            HttpPostedFileBase file = Request.Files["fuprofile"];
            string filename = file.FileName;
            string command = "update TBL_Registration set name='" + txtname + "',lastname='"+txtmob+"', currentadd='"+currentadd+"', profession='"+pro+"',email='"+txtemail+"',cdt='"+DateTime.Now.ToString()+"' where email='" + Session["uid"] + "'";
            if (cm.ExecuteInsertUpdateOrDelete(command) == true)
            {
               // file.SaveAs(Server.MapPath("../Content/Profile/" + file.FileName));

                Response.Write("<script>alert('your Profile Updated Successfully')</script>");
            }
            else
            {
                  Response.Write("<script>alert('your Profile Is Not Updated')</script>");

            }
            return View();
        }

   
        
        public ActionResult Changepassword()
        {
            if (Session["uid"] != null)
            {

            }
            else
            {
                return RedirectToAction("Login","Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Changepassword(string txtold,string txtnew,string txtconfirm)
        {
            if (txtnew == txtconfirm)
            {
                string command = "update TBL_Login set pass='" + em.EncryptData(txtnew) + "' where email='" + Session["uid"].ToString()+ "' and pass='" + em.EncryptData(txtold) + "'";
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
        public ActionResult LogOut()
        {
            // Destroy the value of session
            Session.Abandon();
            return View();
        }

        public ActionResult Dashboard()
          {
              if (Session["uid"] != null)
              {
                  string email = Session["uid"].ToString();
                  string command = " Select * from TBL_Registration Where email='" + email + "'";
                  System.Data.DataTable dt = cm.GetBulksRecord(command);
                  if (dt.Rows.Count > 0)
                  {
                      string name = dt.Rows[0][0].ToString();
                      string picname = "../Content/Profile/" + dt.Rows[0][7].ToString();
                      ViewBag.nm = name;
                      ViewBag.profile = picname;

                  }
                  else
                  {
                      return RedirectToAction("Login", "User");
                  }
              }
             return View();
         }
        [HttpGet]
        public ActionResult Discussion()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Discussion(string txtquestion)
        {
           
            string command = "insert into TBL_question values('" + txtquestion + "','" + Session["uid"].ToString() + "','" + DateTime.Now.ToString() + "')";
            if (cm.ExecuteInsertUpdateOrDelete(command) == true)
            {
                Response.Write("<script>alert('Questin Posted successfuly')</script>");
            }
            else
                Response.Write("<script>alert('Questin Not Posted ')</script>");
            return View();
        }
        [HttpGet]
        public ActionResult GiveAnswer()
        {
            int qid=int.Parse(Request.QueryString["aid"]);
            TempData["qd"] =qid;
            return View();
        }
        [HttpPost]
        public ActionResult GiveAnswer(string txtanswer)
        {
            int qid = int.Parse(TempData["qd"].ToString());
            
            string cmd = "insert into TBL_answer values('"+qid+"','" + txtanswer + "','" + Session["uid"].ToString() + "','" + DateTime.Now.ToString() + "')";

            if (cm.ExecuteInsertUpdateOrDelete(cmd))
            {
                Response.Write("<script>alert('Answer Posted successfully');window.location.href='/User/Discussion'</script>");
            }
                else
            {
                 Response.Write("<script>alert('Answer Not Posted');window.location.href='/User/ViewAnswer'</script>");
            }

            return View();
        }
        public ActionResult ViewAnswer()
        {
       
            return View();
        }

        public ActionResult Feedback()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Feedback(string txtmsg)
        {
        
            string cmd = "insert into TBL_Feedback values('"+ txtmsg + "','" + Session["uid"].ToString() + "','" + DateTime.Now.ToString() + "')";

            if (cm.ExecuteInsertUpdateOrDelete(cmd)==true)
            {
                Response.Write("<script>alert('Feedback Posted successfully');window.location.href='/User/Feedback'</script>");
            }
                else
            {
                 Response.Write("<script>alert('Feedback Not Posted');window.location.href='/User/Feedback'</script>");
            }

            return View();
        
        }
        public ActionResult Notification()
        {
            return View();
        }
        public ActionResult Download()
        {
            return View();
        }
        public ActionResult SharedData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SharedData(string txtfile,string txttype)
        {
            string cmd = "insert into TBL_Shared values('" + txtfile + "','" + txttype + "','"+Session["uid"]+"','" + DateTime.Now.ToString() + "')";
            if (cm.ExecuteInsertUpdateOrDelete(cmd) == true)
            {
                Response.Write("<script>alert('Your file Shared')</script>");
            }
            else
            {
                Response.Write("<script>alert(' your File not Shared')</script>");
            }
            return View();
        }
        public ActionResult What_s()
        {
            return View();
        }
    }
}
