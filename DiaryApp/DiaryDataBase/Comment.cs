using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        public int CommentId { get; set; }

        [ForeignKey("Customer")]
        public int Id { get; set; }
        public virtual Customer Customer { get; set; }

        public bool IsContentAComment(string content)
        {
            if(string.IsNullOrEmpty(content)) return false;
            return true;
        }
    }
}
