using System;
using System.Collections.Generic;
using System.Text;

namespace Business_logic
{
    class GameCompany
    {
        public String Name { get; private set; }
        public BunkAccount BunkAccount { get; private set; }
        public List<Game> GamesList { get; private set; }
        // Developers


        public GameCompany (String name)
        {
            Name = name;
            BunkAccount = new BunkAccount();
            GamesList = new List<Game>();
        }

        public void AddGame(Game game)
        {
            GamesList.Add(game);
        }
    }
}
