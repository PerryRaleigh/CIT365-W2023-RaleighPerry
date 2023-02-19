using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyScriptureJournal.Data;
using MyScriptureJournal.Data.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class AddScriptureEntryModel : PageModel
    {
        private IScriptureRepository scriptureRepo;
        public DateTime dateTime;

        public AddScriptureEntryModel(IScriptureRepository scriptureRepository) 
        {
            this.scriptureRepo = scriptureRepository;
            dateTime = DateTime.Now;
        }

        [BindProperty]
        public ScriptureEntry? NewScriptureEntry { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) { return Page(); }

            NewScriptureEntry!.Created = dateTime;
            this.scriptureRepo.Add(NewScriptureEntry);

            return RedirectToPage("ViewAllScriptureEntries");
        }
    }
}
