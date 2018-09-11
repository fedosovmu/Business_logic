using System;
using System.Collections.Generic;
using System.Text;

namespace Business_logic
{
    class Game
    {
        public String Name { get; private set; }
        public String Description { get; private set; }
        public Money Price { get; private set; }
        public GameCompany DeveloperCompany { get; private set; }
        // Comments
        // News

        public Game (String name, Money price, GameCompany developerCompany, String description="")
        {
            Name = name;
            Price = price;
            Description = description;
            DeveloperCompany = developerCompany;
            developerCompany.AddGame(this);
        }

    }
}
