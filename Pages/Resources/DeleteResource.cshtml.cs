using FarmApplication.Data;
using FarmApplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace FarmApplication.Pages.Resources
{
    public class DeleteResourceModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public FarmResources FR {  get; set; } 

        public DeleteResourceModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            // idk if this is needed 
            FR = _db.Resources.Find(id);
        }
        public async Task<IActionResult> OnPost(int id)
        {
            // problem i think its just trying to delete an id rather then an object
            // fixed it		
            var ResourceFromDB = _db.Resources.Find(id);

            if (ResourceFromDB != null)
            {
                _db.Resources.Remove(ResourceFromDB);
                await _db.SaveChangesAsync();
				TempData["RSuccess"] = $"Resource with id: {id} Deleted";
				return RedirectToPage("ResourceIndex");
            }               
						
			return Page();
		}
    }
}
