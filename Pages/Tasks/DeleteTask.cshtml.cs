using FarmApplication.Data;
using FarmApplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace FarmApplication.Pages.Resources
{
    public class DeleteTaskModel : PageModel
    {
        private readonly ApplicationDBContext _db;
		public FarmTasks tasks { get; set; }

		public DeleteTaskModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            // idk if this is needed 
            tasks = _db.Tasks.Find(id);
        }
        public async Task<IActionResult> OnPost(int id)
        {
            // problem i think its just trying to delete an id rather then an object
            // fixed it		
            var TaskFromDB = _db.Tasks.Find(id);

            if (TaskFromDB != null)
            {
                _db.Tasks.Remove(TaskFromDB);
                await _db.SaveChangesAsync();
				TempData["ESuccess"] = $"Equipment with ID: {id} Deleted";
				return RedirectToPage("Calendar");
            }               
						
			return Page();
		}
    }
}
