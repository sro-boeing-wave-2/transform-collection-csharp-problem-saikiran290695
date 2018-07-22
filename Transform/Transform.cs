using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] list, Func<int, int>condition)
        {
          List<int> response = new List<int>();
            foreach(int present in list)
            {
                response.Add(condition(present));
            }
            return response;
        }
    }
}
