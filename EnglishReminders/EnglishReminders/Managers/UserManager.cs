using EnglishReminders.Entites;
using EnglishReminders.Providers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace EnglishReminders.Managers
{
    public class UserManager
    {
        //Kullanıcı adı kontrolü
        public User UserLogin(string _userName, string _password)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                //Girişin yapılıp yapılamaması durumunda döncek değerin gönderilmesi
                User user = db.DbUsers.Where(u => u.UserName == _userName && u.Password == _password).FirstOrDefault();
                if (user != null)
                    return user;
                else
                {
                    user = null;
                    return user;
                }
            }
        }
        //Kullanıcı kaydı kullanıcı adı kontrolü
        public User UserRegister(string _userName)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                //Girişin yapılıp yapılamaması durumunda döncek değerin gönderilmesi
                User user = db.DbUsers.Where(u => u.UserName == _userName).FirstOrDefault();
                if (user != null)
                    return user;
                else
                {
                    user = null;
                    return user;
                }
            }
        }

        //Başarılı Kullanıcı kaydı
        public int AddUser(string _userName, string _password, string _Name)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                int deg = 0;

                //Kullanıcı kaydı
                List<Words> wordList = db.DbWords.ToList();
                User user = new User()
                {
                    UserName = _userName,
                    Password = _password,
                    Name = _Name
                };
                db.DbUsers.Add(user);
                db.SaveChanges();

                // Ortak tablo Id Kaydı
                foreach (Words item in wordList)
                {

                    UserWords userWords = new UserWords();
                    userWords.UserId = user.Id;
                    userWords.WordsId = item.Id;
                    db.DbuserWords.Add(userWords);
                    db.SaveChanges();
                }

                //Score tablosu id ve değer kaydı
                Score score = new Score()
                {
                    ScorePoint = 0,
                    WrongCount=0,
                    CorrectCout=0,
                    UserId=user.Id
                };
                db.DbScores.Add(score);

                deg = db.SaveChanges();



                return deg;




            }
        }
    }
}
