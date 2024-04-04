using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TopGameRecommendation
{
    public class Recommendation
    {

        public string name;
        List<Games> games = new List<Games>();

        public void AddGame(Games game)
        {
            games.Add(game);
        }

        public void SearchGame(String company)
        {
            foreach (var Game in games)
            {
                if (Game.GamingCompany.Contains(company))
                {
                    Console.WriteLine("Game Found...");
                    DisplayGameInfo(Game);
                }
            }
        }

        public void DisplayGameInfo(Games game)
        {
            Console.WriteLine("GAME INFORMATION : " + name);
            Console.WriteLine("GAME NAME : " + game.GameName);
            Console.WriteLine("GAME DESCRIPTION : " + game.Description);
            Console.WriteLine("GAMING COMPANY : " + game.GamingCompany);
            Console.WriteLine("GAME RELEASE DATE : " + game.ReleaseDate);
        }

        public void DeleteGame(Games game)
        {
            games.Remove(game);
        }
    }
}