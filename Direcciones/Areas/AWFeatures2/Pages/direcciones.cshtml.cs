using AdventureWorksNS.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Direcciones.Areas.AWFeatures2.Pages
{
    public class direccionesModel : PageModel
    {
        private AdventureWorksDB db;

        public List<Address>? direct { get; set; } = null;
        public direccionesModel(AdventureWorksDB injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "AdventureWorks - Direcciones";
            direct = db.Addresses.ToList();

        }

       



    }
}
