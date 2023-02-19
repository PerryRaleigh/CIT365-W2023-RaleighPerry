using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data.Models;

namespace MyScriptureJournal.Data
{
    public class ScriptureRepository : IScriptureRepository
    {
        private ScriptureContext scriptureContext;

        public ScriptureRepository(ScriptureContext context) 
        {
            this.scriptureContext = context;
        }

        public void Add(ScriptureEntry entry)
        {
            this.scriptureContext.ScriptureEntries.Add(entry);
            this.scriptureContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteScripture = scriptureContext.ScriptureEntries.First(x => x.Id == id);
            scriptureContext.ScriptureEntries.Remove(deleteScripture);
            scriptureContext.SaveChanges();
        }

        public ScriptureEntry GetById(int id)
        {
            return scriptureContext.ScriptureEntries.FirstOrDefault(p => p.Id == id)!;
        }

        public List<ScriptureEntry> GetAll()
        {
            return scriptureContext.ScriptureEntries.ToList();
        }

        public void Update(ScriptureEntry entry)
        {
            scriptureContext.Entry(entry).State = EntityState.Modified;
            scriptureContext.SaveChanges();
        }
    }
}
