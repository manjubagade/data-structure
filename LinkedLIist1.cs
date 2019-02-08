using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucure
{
  public class LinkedLIist1
    {
        public void AddList()
        {
            LinkedListClass list = new LinkedListClass();
            list.Add("manju");
            list.Add("harish");
            list.Add("monoj");
            
            Console.WriteLine(list);
        }
    }
}
