using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyScriptureJournal.Data.Models;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class DisplayScriptureEntryModel : PageModel
    {
        private IScriptureRepository scriptureRepo;
        public DateTime dateTime;

        public DisplayScriptureEntryModel(IScriptureRepository scriptureRepository)
        {
            this.scriptureRepo = scriptureRepository;
            dateTime = DateTime.Now;
        }

        [FromRoute]
        public int Id { get; set; }

        [BindProperty]
        public ScriptureEntry? DisplayScriptureEntry { get; set; }

        public void OnGet()
        {
            DisplayScriptureEntry = this.scriptureRepo.GetById(Id);
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("ViewAllScriptureEntries");
        }
    }
}
