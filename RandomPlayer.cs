using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoShamBoLab2023
{
    class RandomPlayer: Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Random rand = new Random();
            int randAtk = rand.Next(0, 3);
            return (Roshambo)randAtk;
        }
    }
}
