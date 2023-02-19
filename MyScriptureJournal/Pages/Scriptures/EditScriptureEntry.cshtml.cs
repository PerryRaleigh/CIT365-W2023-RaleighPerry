using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyScriptureJournal.Data.Models;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class EditScriptureEntryModel : PageModel
    {
        private IScriptureRepository scriptureRepo;
        public DateTime dateTime;

        public EditScriptureEntryModel(IScriptureRepository scriptureRepository)
        {
            this.scriptureRepo = scriptureRepository;
            dateTime = DateTime.Now;
        }

        [FromRoute]
        public int Id { get; set; }

        [BindProperty]
        public ScriptureEntry? EditScriptureEntry { get; set; }

        public void OnGet()
        {
            EditScriptureEntry = this.scriptureRepo.GetById(Id);
        }

        public async Task<IActionResult> OnPostEdit()
        {
            if (!ModelState.IsValid) { return Page(); }

            EditScriptureEntry!.Created = dateTime;
            EditScriptureEntry.Id = Id;
            this.scriptureRepo.Update(EditScriptureEntry);

            return RedirectToPage("ViewAllScriptureEntries");
        }

        public async Task<IActionResult> OnPostDelete()
        {
            this.scriptureRepo.Delete(Id);

            return RedirectToPage("ViewAllScriptureEntries");
        }
    }
}
