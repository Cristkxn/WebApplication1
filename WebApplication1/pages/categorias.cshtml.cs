using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AdventureWorksNS.Data;


namespace WebApplication1.pages
{
    public class categoriasModel : PageModel
    {

        private AdventureWorksDB? db;
        public IEnumerable<ProductCategory>? cat { get; set; }

        [BindProperty]
        public ProductCategory? dato { get; set; }

        public categoriasModel(AdventureWorksDB injectedContext)
        {
            db = injectedContext;
        }
        public void OnGet()
        {
            ViewData["Title"] = "AdventureWorks - Categorias";
            cat = db?.ProductCategories.OrderBy(c=>c.Name);
        }

        public IActionResult OnPost()
        {
            if (dato is not null)
            {
                
                db?.ProductCategories.Add(dato);
                db?.SaveChanges();
                return RedirectToAction("/categorias");
            }
            else
            {
                return Page();
            }
        }




    }
}
