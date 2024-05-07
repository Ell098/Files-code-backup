using FarmApplication.Areas.Identity.Data;
using FarmApplication.Data;
using FarmApplication.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FarmApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        private readonly ILogger<IndexModel> _logger;
        private readonly UserManager<FarmApplicationDBUser> _userManager;


        [BindProperty]
        public DateTime CurrentTime { get; set; }
        public SelectList Days { get; set; }
        public List<FarmTasks> TaskTimetable { get; set; }
        public DateTime DayToView { get; set; }
        public List<FarmTasks> FarmTask { get; set; }
        public DateTime SelectedDay { get; set; } = DateTime.Now.Date;
        public IEnumerable<Workers> WorkersOnFarm { get; set; }

        [ActivatorUtilitiesConstructor]
        public IndexModel(UserManager<FarmApplicationDBUser> userManager, ApplicationDBContext db)
        {
            this._userManager = userManager;
            _db = db;
        }



        public async Task OnGetAsync()
        {
            

            WorkersOnFarm = _db.Workers;

            FarmTask = _db.Tasks
                .Include(ft => ft.FieldValues)
                .Include(ft => ft.ResourcesValues)
                .Include(ft => ft.EquipmentValues)
                .Include(ft => ft.WorkersValues)
                .ToList();


            // Notice -- selectedDay is stuck in american format, whatever option you pick from the drop down gets converted

            TaskTimetable = _db.Tasks
                .ToList();


            Days = new SelectList(await _db.Tasks
                .Select(t => t.TaskStart.Date)
                .Distinct()
                .ToListAsync());

            ViewData["UserID"] = _userManager.GetUserId(this.User);
            CurrentTime = DateTime.Now;
        }

  
    }
}
