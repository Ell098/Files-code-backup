using FarmApplication.Data;
using FarmApplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace FarmApplication.Pages.Resources
{
    public class DeleteWorkerModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public Workers worker {  get; set; } 

        public DeleteWorkerModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            // idk if this is needed 
            worker = _db.Workers.Find(id);
        }
        public async Task<IActionResult> OnPost(int id)
        {
            // problem i think its just trying to delete an id rather then an object
            // fixed it		
            var WorkerFromDB = _db.Workers.Find(id);

            if (WorkerFromDB != null)
            {
                _db.Workers.Remove(WorkerFromDB);
                await _db.SaveChangesAsync();
				TempData["Wsuccess"] = $"Worker with id: {id} Deleted";
				return RedirectToPage("ResourceIndex");
            }               
						
			return Page();
		}
    }
}
