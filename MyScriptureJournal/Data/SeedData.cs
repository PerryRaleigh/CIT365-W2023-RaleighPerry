using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data.Models;

namespace MyScriptureJournal.Data
{
    public static class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScriptureContext>>()))
            {
                if (context == null || context.ScriptureEntries == null)
                {
                    throw new ArgumentNullException("Null ScriptureContext");
                }

                if (context.ScriptureEntries.Any())
                {
                    return;
                }

                DateTime dateTime= DateTime.Now;

                context.ScriptureEntries.AddRange(
                    new ScriptureEntry
                    {
                        Volume = "Doctrine and Covenants",
                        Book = "Section",
                        Chapter = 121,
                        FromVerse = 41,
                        ToVerse = 46,
                        Note = "How we are to influence people, offer correction when needed, and gain confidence in the presence of God. If we do this, the holy ghost will be our constant companion.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Pearl of Great Price",
                        Book = "Moses",
                        Chapter = 1,
                        FromVerse = 39,
                        ToVerse = null,
                        Note = "God work and glory is eternal life for me.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Old Testament",
                        Book = "Isaiah",
                        Chapter = 58,
                        FromVerse = 2,
                        ToVerse = 9,
                        Note = "Proper way to fast. Not to seek the Lord's attention, but to develop compassion for others and care for their needs. This comes with a promise that we will have light, health, and the glory of the Lord will have our backs. Then when we call upon the Lord, He will answer Here I am.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Old Testament",
                        Book = "Proverbs",
                        Chapter = 3,
                        FromVerse = 5,
                        ToVerse = 6,
                        Note = "Trust in the Lord with all thine heart, and He shall direct thy paths.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Book of Mormon",
                        Book = "1 Nephi",
                        Chapter = 3,
                        FromVerse = 7,
                        ToVerse = null,
                        Note = "The attitude I should strive for.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Old Testament",
                        Book = "Isaiah",
                        Chapter = 5,
                        FromVerse = 20,
                        ToVerse = null,
                        Note = "Woe unto them that call evil good, and good evil.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "New Testament",
                        Book = "John",
                        Chapter = 7,
                        FromVerse = 17,
                        ToVerse = null,
                        Note = "Do God’s will to know His doctrine.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "New Testament",
                        Book = "1 Corinthians",
                        Chapter = 2,
                        FromVerse = 5,
                        ToVerse = 11,
                        Note = "We can only know the things of God through the Spirit.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "New Testament",
                        Book = "2 Timothy",
                        Chapter = 3,
                        FromVerse = 15,
                        ToVerse = 17,
                        Note = "Scriptures can make you wise unto salvation.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "New Testament",
                        Book = "James",
                        Chapter = 1,
                        FromVerse = 5,
                        ToVerse = 6,
                        Note = "If you lack wisdom, ask God.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Book of Mormon",
                        Book = "2 Nephi",
                        Chapter = 32,
                        FromVerse = 3,
                        ToVerse = null,
                        Note = "If we feast upon the words of Christ, we can know all things that we should do.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Book of Mormon",
                        Book = "2 Nephi",
                        Chapter = 28,
                        FromVerse = 30,
                        ToVerse = null,
                        Note = "God gives knowledge line upon line.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Book of Mormon",
                        Book = "2 Nephi",
                        Chapter = 32,
                        FromVerse = 8,
                        ToVerse = 9,
                        Note = "If we pray always, God will consecrate our performance for the welfare of our souls.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Book of Mormon",
                        Book = "Mosiah",
                        Chapter = 4,
                        FromVerse = 9,
                        ToVerse = null,
                        Note = "Believe in God and that He has all wisdom.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Book of Mormon",
                        Book = "Ether",
                        Chapter = 12,
                        FromVerse = 6,
                        ToVerse = null,
                        Note = "A witness comes after the trial of faith.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Book of Mormon",
                        Book = "Moroni",
                        Chapter = 10,
                        FromVerse = 4,
                        ToVerse = 5,
                        Note = "The Holy Ghost reveals truth to those who ask God with real intent.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Doctrine and Covenants",
                        Book = "Section",
                        Chapter = 6,
                        FromVerse = 36,
                        ToVerse = null,
                        Note = "Look unto Christ in every thought.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Doctrine and Covenants",
                        Book = "Section",
                        Chapter = 8,
                        FromVerse = 2,
                        ToVerse = 3,
                        Note = "The Holy Ghost speaks to our minds and hearts.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Doctrine and Covenants",
                        Book = "Section",
                        Chapter = 88,
                        FromVerse = 118,
                        ToVerse = null,
                        Note = "Seek learning by study and faith.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Doctrine and Covenants",
                        Book = "Section",
                        Chapter = 29,
                        FromVerse = 10,
                        ToVerse = 11,
                        Note = "Christ will come again with power and glory.Christ will come again with power and glory.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Doctrine and Covenants",
                        Book = "Section",
                        Chapter = 130,
                        FromVerse = 22,
                        ToVerse = 23,
                        Note = "The Father and Son have bodies of flesh and bone.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Pearl of Great Price",
                        Book = "Abraham",
                        Chapter = 3,
                        FromVerse = 22,
                        ToVerse = 23,
                        Note = "Abraham was chosen before he was born.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Pearl of Great Price",
                        Book = "Moses",
                        Chapter = 7,
                        FromVerse = 18,
                        ToVerse = null,
                        Note = "Zion–one heart and one mind in righteousness.",
                        Created = dateTime
                    },
                    new ScriptureEntry
                    {
                        Volume = "Pearl of Great Price",
                        Book = "Moses",
                        Chapter = 7,
                        FromVerse = 28,
                        ToVerse = 33,
                        Note = "God has emotions, He weeps, He wants us to love one another and choose Him.",
                        Created = dateTime
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
