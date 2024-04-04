using System;
using System.Runtime.Serialization;
using TopGameRecommendation;

namespace GameRecommendation
{
    internal class Gameinfos
    {
        static void Main(string[] args)
        {
            Recommendation TopGameRecommended = new Recommendation();
            TopGameRecommended.name = "Recommended Games";

            Games top1Game = new Games();
            top1Game.GameName = "Valorant";
            top1Game.Description = "Valorant is an online multiplayer computer game, produced by Riot Games. It is a first-person shooter game, consisting of two teams of five, where one team attacks and the other defends. Players control characters known as 'agents', who all have different abilities to use during gameplay.";
            top1Game.GamingCompany = "RIOT";
            top1Game.ReleaseDate = "June 2, 2020";

            Games top2Game = new Games
            {
                GameName = "Mobile Legends",
                Description = "Mobile Legend is a mobile multiplayer online battle arena game developed and published by Moonton, a subsidiary of ByteDance. Mobile Legends are also known as Bang Bang or MLBB as ML.",
                GamingCompany = "MOONTON",
                ReleaseDate = "July 14, 2016",
            };


            TopGameRecommended.AddGame(top1Game);
            TopGameRecommended.AddGame(top2Game);

            TopGameRecommended.SearchGame("RIOT");
            TopGameRecommended.DisplayGameInfo(top2Game);
        }
    }
}