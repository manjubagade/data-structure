using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucure
{
    class Utility
    {
        public string FileForUnoderedList()
        {
            string path = @"C:\Users\Admin\Desktop\manjupgm\Algorithms\Algorithmspgm\underredList.txt";
            return path;
        }
        public String ResultForUnderedlist()
        {
            String path = @"C:\Users\Admin\Desktop\manjupgm\Algorithms\Algorithmspgm\ResultList.txt";
            return path;
        }
        public string FileForOrderedList()
        {
            string path = @"C:\Users\Admin\Desktop\manjupgm\Algorithms\Algorithmspgm\orderedList.txt";
            return path;
        }
        public string ResultForlist()
        {
            string path = @"C:\Users\Admin\Desktop\manjupgm\Algorithms\Algorithmspgm\ResultListOrder.txt";
            return path;
        }
        public int GetInt()
        {
            int n = Convert.ToInt32(Console.ReadLine()); 
            return n;
        }
        public double GetDouble()
        {
            Double d = Convert.ToDouble(Console.ReadLine());
            return d;
        }

       
              
        
    
    }
}
