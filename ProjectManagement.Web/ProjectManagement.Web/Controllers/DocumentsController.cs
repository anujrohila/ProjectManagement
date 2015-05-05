using ProjectManagement.DLL.Repositories;
using ProjectManagement.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc;



namespace ProjectManagement.Web.Controllers
{
    [CustomActionAutentication]
    public class DocumentsController : BaseController
    {
        //
        // GET: /Documents/
        [HttpGet]
        public ActionResult Save()
        {
            var supplierDTO = new tblImageMasterDTO();
            ViewBag.Error = "";
            return View(supplierDTO);
        }

        /// <summary>
        ///Get Partial Doc
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public PartialViewResult _PartialShowImage(int DocID)
        {
            var doc = DocumentsRepository.GetDocumentsDetails(DocID);
            return PartialView(doc);
        }

        /// <summary>
        /// List Document Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListDocuementAjax()
        {
            var Docuementdata = DocumentsRepository.GetAllDocumentsDetails();
            var DocData = new List<tblImageMasterDTO>();
            foreach (var item in Docuementdata)
            {
                //  item.ImagesPath = CommonFunctions.WebUrlPrefix
            }
            return View(new GridModel(Docuementdata));
        }

        [HttpPost]
        public ActionResult Save(tblImageMasterDTO tblImageMasterDTO, HttpPostedFileBase FileName)
        {
            if (FileName != null && FileName.ContentLength > 0)
            {
                //string path = System.IO.Path.Combine(Server.MapPath("~/Documents"), System.IO.Path.GetFileName(FileName.FileName));
                //FileName.SaveAs(path);

                ImageUpload imageUpload = new ImageUpload { Height = 800 };

                ImageResult imageResult = imageUpload.RenameUploadFile(FileName);
                if (imageResult.Success)
                {
                    tblImageMasterDTO.CreateBy = 1;
                    tblImageMasterDTO.CreationDateTime = DateTime.Now;
                    tblImageMasterDTO.ImagesPath = imageResult.ImageName;
                    bool retunvalue = DocumentsRepository.SaveDocuement(tblImageMasterDTO);
                    if (retunvalue)
                        return RedirectToAction("ListAll");
                }
                else
                {
                    ViewBag.Error = imageResult.ErrorMessage;
                }
            }
            else
            {
                ViewBag.Error = "Please Select File";
            }
            return View(tblImageMasterDTO);
        }

        public ActionResult ListAll()
        {
            return View();
        }

        /// <summary>
        /// Delete Supplier
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(int Docuementid)
        {
            string result = DocumentsRepository.DeleteDocuement(Docuementid);
            if (result != "")
            {
                string fullPath = Server.MapPath("~/Documents/" + result);
                if (System.IO.File.Exists(fullPath))
                {
                    System.IO.File.Delete(fullPath);
                }
                return Json(new { Success = true, Message = "Document deleted successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }

    }

    public class ImageResult
    {
        public bool Success { get; set; }
        public string ImageName { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ImageUpload
    {
        // set default size here
        public int Width { get; set; }

        public int Height { get; set; }

        // folder for the upload, you can put this in the web.config 
        //System.Web.HttpContext.Current.Server.MapPath("~/Documents/");
        private readonly string UploadPath = System.IO.Path.Combine(System.Web.HttpContext.Current.Server.MapPath(@"~/Documents"));

        public ImageResult RenameUploadFile(HttpPostedFileBase file, Int32 counter = 0)
        {
            var fileName = Path.GetFileName(file.FileName);
            // string prepend = "item_";
            string finalFileName = DateTime.Now.ToString("ddmmyyyyhhmmss") + Path.GetExtension(file.FileName);
            //if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath(UploadPath + finalFileName)))
            //{
            //    //file exists => add country try again
            //    return RenameUploadFile(file, ++counter);
            //}
            //file doesn't exist, upload item but validate first
            return UploadFile(file, finalFileName);
        }

        private ImageResult UploadFile(HttpPostedFileBase file, string fileName)
        {
            ImageResult imageResult = new ImageResult { Success = true, ErrorMessage = null };

            var path = Path.Combine(UploadPath, fileName);
            string extension = Path.GetExtension(file.FileName);

            //make sure the file is valid
            if (!ValidateExtension(extension))
            {
                imageResult.Success = false;
                imageResult.ErrorMessage = "Invalid Extension";
                return imageResult;
            }

            try
            {
                file.SaveAs(path);

                Image imgOriginal = Image.FromFile(path);

                //pass in whatever value you want
                Image imgActual = Scale(imgOriginal);
                imgOriginal.Dispose();
                imgActual.Save(path);
                imgActual.Dispose();

                imageResult.ImageName = fileName;

                return imageResult;
            }
            catch (Exception ex)
            {
                // you might NOT want to show the exception error for the user
                // this is generally logging or testing

                imageResult.Success = false;
                imageResult.ErrorMessage = ex.Message;
                return imageResult;
            }
        }

        private bool ValidateExtension(string extension)
        {
            extension = extension.ToLower();
            switch (extension)
            {
                case ".jpg":
                    return true;
                case ".png":
                    return true;
                case ".gif":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;
            }
        }

        private Image Scale(Image imgPhoto)
        {
            float sourceWidth = imgPhoto.Width;
            float sourceHeight = imgPhoto.Height;
            float destHeight = 0;
            float destWidth = 0;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            // force resize, might distort image
            if (Width != 0 && Height != 0)
            {
                destWidth = Width;
                destHeight = Height;
            }
            // change size proportially depending on width or height
            else if (Height != 0)
            {
                destWidth = (float)(Height * sourceWidth) / sourceHeight;
                destHeight = Height;
            }
            else
            {
                destWidth = Width;
                destHeight = (float)(sourceHeight * Width / sourceWidth);
            }

            Bitmap bmPhoto = new Bitmap((int)destWidth, (int)destHeight, PixelFormat.Format32bppPArgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto, new Rectangle(destX, destY, (int)destWidth, (int)destHeight), new Rectangle(sourceX, sourceY, (int)sourceWidth, (int)sourceHeight), GraphicsUnit.Pixel);

            grPhoto.Dispose();

            return bmPhoto;
        }
    }
}
