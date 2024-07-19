using BulkyProject_Razor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BulkyProject_Razor.Models;


namespace BulkyProject_Razor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public List<Category> categoryList {  get; set; }
        public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            categoryList = _db.Categories.ToList();
        }
    }
}
