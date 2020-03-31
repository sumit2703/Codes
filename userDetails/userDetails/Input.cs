using System;
using System.Collections.Generic;
using System.Text;

namespace userDetails
{
    class Input <T>
    {
        public void store(T Data)
        {
            Program.list.Add(Data);
            
        }
        public static void retreive()
        {
            foreach (var item in Program.list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
