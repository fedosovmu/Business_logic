using System;
using System.Collections.Generic;
using System.Text;

namespace Business_logic
{
    class GameShop
    {
        public List<Game> GamesList { get; private set; }
        public List<User> UsersList { get; private set; }
        //Buys
        //Refunds
        //Gifts

        public GameShop ()
        {
            GamesList = new List<Game>();
            UsersList = new List<User>();
        }

        public void AddGame(Game game)
        {
            GamesList.Add(game);
        }

        public void AddUser(User user)
        {
            UsersList.Add(user);
        }

    }
}
