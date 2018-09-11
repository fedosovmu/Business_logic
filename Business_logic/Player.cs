using System;
using System.Collections.Generic;
using System.Text;

namespace Business_logic
{
    class Player : User
    {
        public BunkAccount BunkAccount { get; private set; }
        public List<Game> GamesList { get; private set; }


        Player(String login, String password, BunkAccount bunkAccount)
            : base(login, password)
        {
            GamesList = new List<Game>();
            BunkAccount = bunkAccount;
        }


    }
}
