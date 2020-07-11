using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EnglishReminders.Entites
{
   public class Words
    {
        public int Id { get; set; }

        public string Turkish { get; set; }
        public string English { get; set; }
      
        public List<UserWords> UserWords { get; set; }

        public override string ToString()
        {
            return this.Turkish;
        }
    }
}
