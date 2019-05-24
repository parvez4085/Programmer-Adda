using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace ProgrammerAdd.Models
{
    public class FileManager
    {
        public string FolderName;
        public HttpPostedFileBase FileName;
        public bool SaveFile()
        {
            try
            {
                Directory.CreateDirectory("../Content/" + FolderName);
                FileName.SaveAs(HttpContext.Current.Server.MapPath("../Content/" + FolderName + "/" + FileName.FileName));

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}