using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammerAdd.Models
{
    public class CaptchaGenerator
    {
      public string GetCaptchaCode()
        {
            string code="";
            Random rm=new Random();
            int n1 = rm.Next(48, 57);
            int n2 = rm.Next(97,122);
            int n3 = rm.Next(65,90);
            int n4 = rm.Next(48,57);
            int n5 = rm.Next(98,121);
            int n6 = rm.Next(65,80);
            char c1 = (char)n1;
            char c2 = (char)n2;
            char c3 = (char)n3;
            char c4 = (char)n4;
            char c5 = (char)n5;
            char c6 = (char)n6;
            code = code + c1 + c2 + c3 + c4 + c5 + c6;
            return code;
        }
    }
}