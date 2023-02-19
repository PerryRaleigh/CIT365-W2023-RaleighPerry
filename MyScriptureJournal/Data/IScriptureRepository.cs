using MyScriptureJournal.Data.Models;

namespace MyScriptureJournal.Data
{
    public interface IScriptureRepository
    {
        public void Add(ScriptureEntry entry);
        public void Update(ScriptureEntry entry);
        public ScriptureEntry GetById(int id);
        public List<ScriptureEntry> GetAll();
        public void Delete(int id);
    }
}
