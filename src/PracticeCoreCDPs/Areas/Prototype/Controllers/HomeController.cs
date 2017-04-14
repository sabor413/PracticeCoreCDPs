using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PracticeCoreCDPs.Areas.Prototype.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using System.IO;

namespace PracticeCoreCDPs.Areas.Prototype.Controllers
{
    [Area("Prototype")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(IList<IFormFile> files)
        {
            foreach (var file in files)
            {

                ContentDispositionHeaderValue header = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
                string fileName = header.FileName;
                fileName = fileName.Trim('"');
                fileName = Path.GetFileName(fileName);
                MemoryStream ms = new MemoryStream();
                Stream s = file.OpenReadStream();
                s.CopyTo(ms);
                byte[] data = ms.ToArray();
                s.Close();
                ms.Close();

                UploadedFile primaryObj = new UploadedFile
                {
                    FileName = fileName,
                    ContentType = file.ContentType,
                    Size = file.Length,
                    TimeStamp = DateTime.Now,
                    FileContent = data
                };

                IUploadedFile backupObj = primaryObj.Clone();
                
                //send primaryObj to main system 
                //send backupObj to backup system
            }

            ViewBag.Message = files.Count + " file(s) uploaded successfully!";
            return View("Index");
        }
    }
}
