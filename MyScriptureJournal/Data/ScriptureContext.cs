using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data.Models;

namespace MyScriptureJournal.Data
{
    public class ScriptureContext : DbContext
    {
        public ScriptureContext(DbContextOptions options) : base(options) { }

        public DbSet<ScriptureEntry> ScriptureEntries { get; set; }
    }
}
