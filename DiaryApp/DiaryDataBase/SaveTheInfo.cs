using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryDataBase
{
    public class SaveTheInfo
    {

        // Fix CS1520: Method must have a return type by adding void return type
        public void SaveData(string username, string password)
        {
            using (var _context = new AppContext())
            {
                var user = new User();
                user.userName = username;
                var pass = new Password();
                pass.password = password;
                _context.SaveChanges();
            }
        }
    }
}
