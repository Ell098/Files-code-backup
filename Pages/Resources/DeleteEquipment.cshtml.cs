using FarmApplication.Data;
using FarmApplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace FarmApplication.Pages.Resources
{
    public class DeleteEquipmentModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public Equipment eq {  get; set; } 

        public DeleteEquipmentModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            // idk if this is needed 
            eq = _db.Equipment.Find(id);
        }
        public async Task<IActionResult> OnPost(int id)
        {
            // problem i think its just trying to delete an id rather then an object
            // fixed it		
            var EquipmentFromDB = _db.Equipment.Find(id);

            if (EquipmentFromDB != null)
            {
                _db.Equipment.Remove(EquipmentFromDB);
                await _db.SaveChangesAsync();
				TempData["ESuccess"] = $"Equipment with ID: {id} Deleted";
				return RedirectToPage("ResourceIndex");
            }               
						
			return Page();
		}
    }
}
