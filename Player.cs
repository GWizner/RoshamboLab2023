using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoShamBoLab2023
{
    abstract class Player
    {
        public enum Roshambo
        {
            Rock,
            Paper,
            Scissors
        }
        public string name { get; set; }
        public Roshambo JanKenPon = Roshambo.Rock;
        public Roshambo playerAtk;

        public virtual Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
