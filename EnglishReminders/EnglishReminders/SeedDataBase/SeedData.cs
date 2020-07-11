using EnglishReminders.Entites;
using EnglishReminders.Providers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishReminders.SeedDataBase
{
    public static class SeedData
    {
        //Hazır verilerin Yüklenmesi
        public static void DataSeeding(DbContext context)
        {
            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context is DatabaseContext)
                {
                    DatabaseContext _context = new DatabaseContext();
                    if (_context.DbWords.Count()==0)
                    {
                        _context.DbWords.AddRange(Words);
                    }
                    _context.SaveChanges();
                }
            }
        }

        private static List<Words> Words = new List<Words>()
        {
                new Words{English="Pencil",Turkish="Kalem"},
                new Words{English="Ready",Turkish="Hazır"},
                new Words{English="Table",Turkish="Tablo"},
                new Words{English="Screen",Turkish="Ekran"},
                new Words{English="Light",Turkish="Işık"},
                new Words{English="Water",Turkish="Su"},
                new Words{English="Iron",Turkish="Demir"},
                new Words{English="Box",Turkish="Kutu"},
                new Words{English="Circle",Turkish="Daire"},
                new Words{English="Square",Turkish="Kare"},
                new Words{English="Glass",Turkish="Cam"},
                new Words{English="Wall",Turkish="Duvar"},
                new Words{English="Flower",Turkish="Çiçek"},
                new Words{English="Carpet",Turkish="Halı"},
                new Words{English="Forget",Turkish="Unutmak"},
                new Words{English="Calculate",Turkish="Hesaplamak"},
                new Words{English="Eye",Turkish="Göz"}
        };
    }
}
