using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryDataBase
{
    public class Comment
    {
        
        public string title { get; set; }
        public string  comment { get; set; }
        public int commentId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsContentAComment(string content)
        {
            if(string.IsNullOrEmpty(content)) return false;
            return true;
        }
    }
}
