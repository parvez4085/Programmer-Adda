using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProgrammerAdd.Models;
using System.Data;
using System.Net.Mail;
using System.Net;

using System.Data.SqlClient;

namespace ProgrammerAdd.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        ConnectionManager cm = new ConnectionManager();
        EncryptionManager em = new EncryptionManager();
       
        private void SendEmail(string txtname, string email, string password)
        {
            SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.Credentials = new System.Net.NetworkCredential("parvez.ansari4085@gmail.com", "Parvez.ansari786");
        smtp.EnableSsl = true;
        MailMessage msg = new MailMessage();
        msg.Subject = "Forgot Password ( Programmer Adda )";
        msg.Body = "Dear " + txtname + ", Your Password is  " + password + "\n\n\nThanks & Regards\nProgrammer Aadd Team";
        string toaddress = email;
        msg.To.Add(toaddress);
        string fromaddress = "Programmer Adda <parvez.ansari4085@gmail.com>";
        msg.From = new MailAddress(fromaddress);
        try
        {
            smtp.Send(msg);


        }
        catch
        {
            throw;
        }
    }
 

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OurObjective()
        {
            return View();
        }
        public ActionResult ImageGallery()
        {
            return View();
        }
    [HttpGet]
        public ActionResult Enquiry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Enquiry(string txtname,string txtmob,string txtemail, string txtcadd)
        {
            string cmd = "insert into TBL_Enquiry values('" + txtname + "','" + txtmob + "','"+txtemail+"','" + txtcadd + "','"+DateTime.Now.ToString()+"')";
           
            if (cm.ExecuteInsertUpdateOrDelete(cmd)==true)
            {
                Response.Write("<script>alert('Your Enquiry Is Completed Successfully')</script>");
            }
            else
            {
                Response.Write("<script>alert('Your enquiry Is Not Successfully')</script>");
            }
            return View();
        }

        [HttpGet]
        public ActionResult NewUserRegistration()
        {
            CaptchaGenerator cg = new CaptchaGenerator();
            string CaptchaCode = cg.GetCaptchaCode();
            ViewBag.code = CaptchaCode;
            return View();
        }
        [HttpPost]
        public ActionResult NewUserRegistration(FormCollection frm)
        {
            FileManager fm = new FileManager();

            string name = frm["txtname"].ToString();
            string lname = frm["lastadd"].ToString();
            string CurntAdd = frm["txtcadd"].ToString();
            string Mobile = frm["txtmob"].ToString();
            string email = frm["txtemail"].ToString();
            string profession = frm["txtpro"].ToString();
            string pass = frm["txtpass"].ToString();
            string ocode = frm["txtccode"].ToString().Trim();
            string txtcode = frm["txtcaptcha"].ToString().Trim();
            HttpPostedFileBase file = Request.Files["profile"];
            if (ocode == txtcode)
            {
                string mycommand = "insert into TBL_Registration values('" + name + "','"+lname+"','"
                    + Mobile + "','" + CurntAdd + "','" + profession + "','" + email + "','" + em.EncryptData(pass) + "','"
                    + file.FileName + "','" +DateTime.Now.ToString() + "')";
                bool x = cm.ExecuteInsertUpdateOrDelete(mycommand);
                if (x == true)
                {
                    file.SaveAs(Server.MapPath("../Content/Profile/" + file.FileName));
                    string command = "insert into TBL_Login values('" + email + "','" + em.EncryptData(pass) + "','user')";
                    if (cm.ExecuteInsertUpdateOrDelete(command))
                    {
                        Response.Write("<script>alert('Your Registration Is Completed Successfully')</script>");
                    }

                    else
                    {
                        Response.Write("<script>alert('Your Registration Is Not Completed')</script> ");
                    }

                }
                else
                {
                    Response.Write("<script>alert('Invalid Captcha Code')</Script>");
                }

                
            }
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(string txtuserid,string txtpass)
        {
            string cmd = "select *from TBL_Login where email='" + txtuserid + "' and pass='" + em.EncryptData(txtpass)+ "'";

            System.Data.DataTable dt = cm.GetBulksRecord(cmd);
            if (dt.Rows.Count > 0)
            {
                string Userid = dt.Rows[0][0].ToString();
                string Password = dt.Rows[0][1].ToString();
                string utype= dt.Rows[0][2].ToString();
                if ((Userid == txtuserid) && (Password == em.EncryptData(txtpass))&&(utype=="user"))
                {
                    //set email Into The session
                    Session["uid"] = txtuserid;
                    return RedirectToAction("Index", "User");
                }
                    else if((Userid == txtuserid) && (Password == em.EncryptData(txtpass))&&(utype=="admin"))
                      {
                        // set email for admin into session
                        Session["aid"]=txtuserid;
                        return RedirectToAction("Index","Admin");
                     }
                else
                {
                    Response.Write("<script>alert('Invalid User Id or Password')</script");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid User Id or Password')</script");
            }
            return View();
        }
        
        public ActionResult Test()
        {
           return View();
        }
        public ActionResult newslider()
        {
            return View();

        }
        [HttpGet]
        public ActionResult ForgetPassword()
       {
         
           return View();
       }
    [HttpPost]
        public ActionResult ForgetPassword(string txtname, string txtuserid)
    {
        
        string myquery = "Select * from TBL_Registration where name='" + txtname+ "' and email='" +txtuserid + "'";
        System.Data.DataTable dt = cm.GetBulksRecord(myquery);
        if (dt.Rows.Count > 0)
        {
            string Password;
            //Console.Write("Data is found");
            Password = dt.Rows[0]["password"].ToString();
            SendEmail(txtname, txtuserid, Password);
            Response.Write("<script>alert(' Password Send to Registerted E-mail id Plzz Check email') </script>");
        }
        else
        {
            Response.Write("<script>alert('Email id and user name is not match to database') </script>");
        }
         return View();
    }
    }
}
