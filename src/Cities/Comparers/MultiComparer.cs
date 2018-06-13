using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class MultiComparer:IComparer<City>
    {
        public IList<IComparer<City>> Comparers = new List<IComparer<City>>();

        public int Compare(City x, City y)
        {
            int result = 0;
            for (int i = 0; i < Comparers.Count; i++)
            {
                IComparer<City> currentComparer = Comparers[i];
                
                result = currentComparer.Compare(x, y);
                if (result != 0)
                {
                    return result;
                }
            }
            return result;
            
        }
    }
}
