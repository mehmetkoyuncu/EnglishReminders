using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishReminders.Entites
{
   public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public List<UserWords> UserWords { get; set; }
        public Score Score { get; set; }

    }
}
