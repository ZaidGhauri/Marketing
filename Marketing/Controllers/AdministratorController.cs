using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketing.Controllers
{
    public class AdministratorController : Controller
    {
        //
        // GET: /Administrator/
        public ICategoryRepository categoryRepository { get; set; }
        public IImageRepository imageRepository { get; set; }




        public ActionResult Index()
        {
            if (Session["UName"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        public ActionResult UploadFiles(IEnumerable<HttpPostedFileBase> files)
        {
            try
            {
                if (files != null)
                {
                    string fileName, filePath, fileExtension, savedExcelFiles;
                    List<Marketing.Business.Models.Category> lstUploads = new List<Marketing.Business.Models.Category>();
                    foreach (var file in files)
                    {
                        List<Marketing.Business.Models.Category> lstFile = new List<Marketing.Business.Models.Category>();
                        SetFileDetails(file, out fileName, out filePath, out fileExtension);
                        if (fileExtension == ".xls" || fileExtension == ".xlsx")
                        {
                            savedExcelFiles = "~/App_Data/Storage/Excel/" + fileName;
                            file.SaveAs(Server.MapPath(savedExcelFiles));
                            lstFile = ReadDataFromExcelFiles(savedExcelFiles);
                        }
                        lstUploads.AddRange(lstFile);
                    }
                    using (categoryRepository = new CategoryRepository())
                    using (imageRepository = new ImageRepository())
                    {
                        foreach (var category in lstUploads)
                        {
                            var image = new Image()
                            {
                                Name = category.ImagePath,
                                Created = DateTimeHelper.Now(),
                                CreatedBy = Session["UName"].ToString(),
                                IsActive = true,
                                Modified = DateTimeHelper.Now(),
                                ModifiedBy = Session["UName"].ToString()
                            };
                            image = imageRepository.Insert(image); 

                            Category model = new Category();
                            model.Name = category.Name;
                            model.Published = category.Published;
                            model.ShowOnHomePage = category.ShowOnHomePage;
                            model.ParentCategoryId = categoryRepository.FindByName(category.ParentCategoryName);
                            model.IsFeatured = category.IsFeatured;
                            model.IncludeInTopMenu = category.IncludeInTopMenu;
                            model.Description = category.Description;
                            model.Deleted = category.Deleted;
                            model.ImageId = image.Id;
                            model.WebSiteId = category.WebSiteId;
                            model.IsActive = category.IsActive;
                            model.Created = category.Created;
                            model.CreatedBy = category.CreatedBy;
                            model.Modified = category.Modified;
                            model.ModifiedBy = category.ModifiedBy;
                            categoryRepository.Insert(model);
                        }
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        private static void SetFileDetails(HttpPostedFileBase f, out string fileName, out string filepath, out string fileExtension)
        {
            fileName = Path.GetFileName(f.FileName);
            fileExtension = Path.GetExtension(f.FileName);
            filepath = Path.GetFullPath(f.FileName);
        }

        private List<Marketing.Business.Models.Category> ReadDataFromExcelFiles(string savedExcelFiles)
        {
            OleDbConnection connectionString = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath(savedExcelFiles) + ";Extended Properties='Excel 12.0 xml;HDR=YES;'");
            connectionString.Open();
            DataTable Sheets = connectionString.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            DataTable data = new DataTable();
            foreach (DataRow dataR in Sheets.Rows)
            {
                string sheetStr = dataR[2].ToString().Replace("'", "");
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select * from [" + sheetStr + "]", connectionString);
                var ds = new DataSet();
                dataAdapter.Fill(ds, "DataTable");
                data = ds.Tables["DataTable"];
            }
            List<Marketing.Business.Models.Category> lstUpload = new List<Marketing.Business.Models.Category>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Marketing.Business.Models.Category newFile = new Marketing.Business.Models.Category();
                newFile.Name = Convert.ToString(data.Rows[i]["Name"]);
                newFile.Published = Convert.ToBoolean(data.Rows[i]["Published"]);
                newFile.ShowOnHomePage = Convert.ToBoolean(data.Rows[i]["ShowOnHomePage"]);
                newFile.ParentCategoryName = Convert.ToString(data.Rows[i]["ParentCategory"]);
                newFile.IsFeatured = Convert.ToBoolean(data.Rows[i]["IsFeatured"]);
                newFile.IncludeInTopMenu = Convert.ToBoolean(data.Rows[i]["IncludeInTopMenu"]);
                newFile.Description = Convert.ToString(data.Rows[i]["Description"]);
                newFile.ImagePath = Convert.ToString(data.Rows[i]["ImagePath"]);
                newFile.Deleted = Convert.ToBoolean(data.Rows[i]["Deleted"]);
                newFile.WebSiteId = Convert.ToInt32(data.Rows[i]["WebSiteId"]);
                newFile.IsActive = Convert.ToBoolean(data.Rows[i]["IsActive"]);
                newFile.Created = DateTimeHelper.Now();
                newFile.CreatedBy = Session["UName"].ToString();
                newFile.Modified = DateTimeHelper.Now();
                newFile.ModifiedBy = Session["UName"].ToString();
                lstUpload.Add(newFile);
            }
            return lstUpload;
        }

    }
}
