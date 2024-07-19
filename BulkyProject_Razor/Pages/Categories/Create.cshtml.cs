using BulkyProject_Razor.Data;
using BulkyProject_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyProject_Razor.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public Category category { get; set; }
        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToPage("Index");

        }
    }
}
