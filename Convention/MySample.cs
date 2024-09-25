using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Convention
{
    public class MySample
    {
        public List<int> MyList { get; private set; }
        // public IReadOnlyList<int> MyList { get; private set; } << change reference type to readonly 

        public MySample()
        {
            MyList = new List<int>() { 1, 2, 3, 4, 5 };
        }
    }
}