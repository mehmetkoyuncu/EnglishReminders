using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishReminders.Entites
{
    public class Score
    {
        public int Id { get; set; }
        public int CorrectCout { get; set; }
        public int WrongCount { get; set; }
        public int ScorePoint { get; set; }

        public User  User { get; set; }
        public int UserId { get; set; }


    }
}
