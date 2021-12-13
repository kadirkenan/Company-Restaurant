
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common
{
    public class ImageUploader
    {

        /*
          0 => file is empty
          1 => "This image has already beed added."
          2 => "unsuitable format."
          3 => "Successful"
       */

        //public static string UploadImage(string serverPath, HttpPostedFileBase file)
        //{
        //    var fileName = "";
        //    if (file != null)
        //    {
        //        var uniqueName = Guid.NewGuid();
        //        serverPath = serverPath.Replace("~", "");
        //        var fileArray = file.FileName.Split('.');
        //        string extension = fileArray[fileArray.length - 1];
        //        fileName = uniqueName + "." + extension;
        //        if (extension == "png" || extension == "jpg" || extension == "jpeg" || extension == "gif")
        //        {
        //            if (File.Exists(HttpContext.Current.Server.MapPath(serverPath + fileName)))
        //            {
        //                try
        //                {
        //                    var filePath = HttpContext.Current.Server.MapPath(serverPath + "\\" + fileName);
        //                    file.SaveAs(filePath);
        //                    return fileName;
        //                }
        //                catch (Exception ex)
        //                {
        //                    return ex.Message;
        //                    throw;
        //                }
        //            }
        //            else
        //            {
        //                return "1";
        //            }

        //        }
        //        else
        //        {
        //            return "2";
        //        }
        //    }
        //    else
        //    {
        //        return "3";
        //    }
        //}
    }
}
