using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shot_Game
{
    public class Shoot
    {
        Random rd = new Random();
        //this metho is used to reset the method 
        public int reset() {
            return 1;
        }

        public int trigger() {
           int y = rd.Next(3, 5);

            return y;
        }

    }
}
