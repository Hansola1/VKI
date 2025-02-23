using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    public static class UserSession 
    {
        public static bool IsLoggedIn { get; set; }
        public static string CurrentUserLogin { get; set; }
    }

}
