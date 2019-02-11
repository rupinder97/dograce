using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dograce
{
    class AI : Punter 
    {
        public int aibetting;
        // Ai constructor is created when object is intilized i.e. Form1.cs

        public void Bobbet(int b)
        {
            aibetting = b;
        }


    }
}
