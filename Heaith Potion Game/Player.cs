using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaith_Potion_Game
{
    public class Player
    {
        public int Health { ref int health , int  } = 85;
        public void UseHealthPotion(int potion = 20)
        {

            Health += potion;
            if (Health > 100)

            {
                Health = 100;
            }
        }
    }
}
