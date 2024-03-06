using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryDataBase
{
    public class Password
    {
        public string password { get; set; }
        public int passwordId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsvalidPassWord(string passwordtest)
        {
            //char[] chars = passwordtest.ToCharArray();
            //foreach (char c in chars)
            //{
            //    if (!char.IsUpper(c))
            //    {
            //        return false;
            //    }
            //}
             if (string.IsNullOrEmpty(passwordtest))
            {
                return false;
            }
            if(passwordtest.Length < 8)
            {
                return false ;
            }
            if (!char.IsUpper(passwordtest[0]))
            {
                return false;
            }
           
            
           
            return true;
        }
    }
}
