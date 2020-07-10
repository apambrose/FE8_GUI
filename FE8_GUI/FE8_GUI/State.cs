using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE8_GUI
{
    static class State
    {
        public static int state = 0;
        public static void SetState(int newstate) 
        {
            state = newstate;
        }
    }
}
