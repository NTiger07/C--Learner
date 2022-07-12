using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("@olaleru"));
            players.Add(new Player("@ipomjiuy"));
            players.Add(new Player("@hatake"));
            players.Add(new Player("@uchiha"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
        }
    }
    class Player
    {
        public String userName;
        public Player(String userName)
        {
            this.userName = userName;
        }
        public override String ToString()
        {
            return userName;
        }

    }
}



