using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoM_and_MCE_Generator_Reloaded.Miscellaneous_Classes
{
    public class UserData
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate{ get; set; }
        public string Access { get; set; }
        public int BoMs { get; set; }
        public UserData()
        {
            this.Username = "";
            this.Password = "";
            this.Birthdate = DateTime.Now;
            this.Access= "";
            this.BoMs = 0;
        }
    }
}
