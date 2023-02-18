using RoShamBoLab2023;
using System.Xml.Linq;

Console.WriteLine("Welcome to ULTIMATE JANKENPON. Once you register your name, you will be directed to choose your weapon (Rock," +
    " Paper, or Scissors). Then enter the arena and let the mayhem commence!!!\n");

Console.WriteLine("Fighter, please enter your name: ");
string name = Console.ReadLine();

bool keepAsk = true;
int wins = 0;

while (keepAsk)
{
    HumanPlayer player1 = new HumanPlayer(name);
    Player.Roshambo plyrAtk = player1.playerAtk; 
    Player.Roshambo oppAtk = new Player.Roshambo();
    //Player.Roshambo plyrAtk = new Player.Roshambo();
    //plyrAtk = player1.GenerateRoshambo();
    Player opponent = null;
	
	wins = Validator.GetOpp(player1, opponent, oppAtk, plyrAtk, wins);
    
    
	keepAsk = Validator.GetContinue();
}
if (wins == 1)
    Console.WriteLine($"You have won {wins} game. Later, Poseur.");

else
    Console.WriteLine($"You have won {wins} games. Later, Poseur.");
