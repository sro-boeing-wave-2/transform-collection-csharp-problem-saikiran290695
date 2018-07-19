using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] x, Func<int, int>condition)
        {
          List<int> temp = new List<int>();
            foreach(int present in x){
                temp.Add(condition(present));
            }
            return temp;
        }
    }
}
