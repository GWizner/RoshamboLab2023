using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoShamBoLab2023
{
    class HumanPlayer : Player
    {
        public string newName { get; set; }
        public HumanPlayer(string name)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            newName = textInfo.ToTitleCase(name);
            Console.WriteLine();
            playerAtk = Validator.GetPlyr(newName);
        }
    }
}
