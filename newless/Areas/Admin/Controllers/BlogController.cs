using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using newless.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace newless.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var book=new XLWorkbook())
            {
                var worksheet = book.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog Id";
                worksheet.Cell(1, 2).Value = "Blog Adi";

                int blogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(blogRowCount, 1).Value = item.Id;
                    worksheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++;
                }
                using (var stream=new MemoryStream())
                {
                    book.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","Calisma1.xlsx");
                }
            }
        }
        public IActionResult BlogListExcel()
        {
            return View();
        }
        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel{Id=1,BlogName="emin"},
                new BlogModel{Id=2,BlogName="rasim"}
            };
            return bm;
        }

        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adi";

                int RowCount = 2;
                foreach (var item in BlogTitleList())
                {
                    worksheet.Cell(RowCount, 1).Value = item.Id;
                    worksheet.Cell(RowCount, 2).Value = item.Name;
                    RowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformmats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                }
            }
        }

        public List<BlogModel2> BlogTitleList()
        {
            List<BlogModel2> bm = new List<BlogModel2>();
            using (var myContext = new MyContext())
            {
                bm = myContext.Blogs.Select(x => new BlogModel2
                {
                    Id = x.Id,
                    Name = x.Title
                }).ToList();
            }
            return bm;
        }

        public IActionResult BlogTitleListExcel()
        {
            return View();
        }
    }
}
