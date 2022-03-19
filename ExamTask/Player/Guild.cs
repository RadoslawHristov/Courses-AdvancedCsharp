using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Player> Roster { get; set; }
        public int Count => Roster.Count;


        public void AddPlayer(Player player)
        {
            if (Roster.Count < Capacity)
            {
                Roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            var curentplayer = Roster.Where(x => x.Name == name).FirstOrDefault();
            if (curentplayer==null)
            {
                return false;
            }

            Roster.Remove(curentplayer);
            return true;
        }

        public void PromotePlayer(string name)
        {
            var player = Roster.Where(x => x.Name == name).First();
            if (player.Rank != "Member")
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            var player = Roster.Where(x => x.Name == name).First();
            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            Player[] player = Roster.FindAll(x=>x.Class==@class).ToArray();
            var remove = Roster.FindAll(x => x.Class == @class);
            Roster.RemoveAll(remove.Contains);
            return player;
        }

        public string Report()
        {
            StringBuilder sv = new StringBuilder();
            Console.WriteLine($"Players in the guild: {this.Name}");

            foreach (var player in Roster)
            {
                sv.AppendLine(player.ToString().Trim());
            }

            return sv.ToString();
        }
    }
}
