using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp
    //klass Konto för att kunna skapa ett konto så måste du ha ett namn och måste ha också ett user id 
    //därför är den en abstract klass för att den är viktig för att skapa ett konto.
    //namnet ska hanteras också här innan den ska bli valid för att använda den. 
{
    public abstract class Konto
    {
        //protected string username;
        //protected int Id;
        //public Konto(string username, int Id)
        //{
        //     Username = username;
        //     this.UserId = Id;

        //}
        //public string UserName
        //{
        //    get { return username; }

        //}
        //public int UserId
        //{
        //    get { return Id; }
        //}
        public abstract bool IsvalidName(string name );
    }
}
