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
        
        public string title { get; set; } //titel
        public string  comment { get; set; } // kommentaren som användaren ska lägga upp 
        public DateTime CommentDate { get; set; } // lika med DateTime.Now för att få den kommentaren den datumet där kommentaren skrivs 
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
