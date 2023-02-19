using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyScriptureJournal.Data;
using MyScriptureJournal.Data.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class ViewAllScriptureEntriesModel : PageModel
    {
        private IScriptureRepository scriptureRepository;
        public List<ScriptureEntry>? ScriptureEntries { get; set; }

        public ViewAllScriptureEntriesModel(IScriptureRepository scriptureRepository)
        {
            this.scriptureRepository = scriptureRepository;
        }

        public void OnGet()
        {
            ScriptureEntries = scriptureRepository.GetAll();
        }
    }
}
