using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishReminders.Entites
{
    public class UserWords
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int WordsId { get; set; }
        public Words Words { get; set; }
       public bool IsAnswered { get; set; }

    }
}
