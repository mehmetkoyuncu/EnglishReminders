using EnglishReminders.Entites;
using EnglishReminders.Providers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace EnglishReminders.Managers
{
    public class WordManager
    {
        //Kullanıcın kelimelerini getir
        public List<Words> getAllWords(User _user)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                List<Words> wordList = new List<Words>();
                wordList = db.DbuserWords.Include(x => x.Words).Where(x => x.UserId == _user.Id).Select(x => x.Words).ToList();
                return wordList;
            }
        }

        //Kelime Ekle
        public int AddWord(string _wordTurkish, string _wordEnglish, User user)
        {

            using (DatabaseContext db = new DatabaseContext())
            {
                //Kelime Ekle
                Words newWord = new Words();
                newWord.Turkish = _wordTurkish;
                newWord.English = _wordEnglish;
                db.DbWords.Add(newWord);
                db.SaveChanges();

                //Ortak tablo id ekle
                UserWords uw = new UserWords();
                uw.UserId = user.Id;
                uw.WordsId = newWord.Id;
                db.DbuserWords.Add(uw);

                return db.SaveChanges();


            }

        }


        //Kelime  Silme
        public int DeleteWord(int id, User _user)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                UserWords delete = db.DbuserWords.Where(x => x.WordsId == id && x.UserId == _user.Id).FirstOrDefault();
                db.DbuserWords.Remove(delete);
                int result = db.SaveChanges();
                return result;
            }
        }


        //Rastgele  Kelime Getirme
        public Words getRandomWord(User _user)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                Words word = new Words();
                word = db.DbuserWords.Include(x => x.Words).Where(x => x.UserId == _user.Id&&x.IsAnswered==false)
                    .Select(x => x.Words).OrderBy(w => Guid.NewGuid()).Take(1).FirstOrDefault();
                return word;
            }
        }
        
        //Soruların bilinme durumunu değiştirme
        public void changeAnsweredWord(Words _word, User _user)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                UserWords word = new UserWords();
                word = db.DbuserWords.Where(x => x.WordsId == _word.Id && x.UserId==_user.Id).FirstOrDefault();
                word.IsAnswered = true;
                db.DbuserWords.Update(word);
                db.SaveChanges();
            }

        }

        //Kelimeleri Resetleme
        public void Reset(User user)
        {
            using (DatabaseContext db=new DatabaseContext())
            {
                List<UserWords> uw = new List<UserWords>();
                uw = db.DbuserWords.Where(x => x.UserId == user.Id).ToList();
                foreach (UserWords item in uw)
                {
                    item.IsAnswered = false;
                    db.SaveChanges();
                }
            }
        }
    }

}
