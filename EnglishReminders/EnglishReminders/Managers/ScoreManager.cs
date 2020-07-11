using EnglishReminders.Entites;
using EnglishReminders.Providers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishReminders.Managers
{
   public class ScoreManager
    {
        //Score Getir
        public Score getScore(User _user)
        {
            using (DatabaseContext db=new DatabaseContext())
            {
                Score score = db.DbScores.Where(x => x.UserId == _user.Id).FirstOrDefault();
                return score;
            }
        }

        //Puanlama Sistemi
        public void updateScore(User _user,bool _isCorrect)
        {
           
            using (DatabaseContext db=new DatabaseContext())
            {
                Score score = db.DbScores.Where(x => x.UserId == _user.Id).FirstOrDefault();
                if (_isCorrect)
                {
                    score.ScorePoint += 10;
                    score.CorrectCout += 1;
                }
                else
                {
                    score.ScorePoint -= 5;
                    score.WrongCount += 1;
                }
                db.SaveChanges();



            }
         
        }

        //Score Sıfırlama
        public Score resetScore(User _user)
        {
            using(DatabaseContext db=new DatabaseContext())
            {
                Score score = db.DbScores.Where(x => x.UserId == _user.Id).FirstOrDefault();
                score.ScorePoint = 0;
                score.CorrectCout = 0;
                score.WrongCount = 0;
                db.SaveChanges();

                return score;
            }

        
        }

    }
}
