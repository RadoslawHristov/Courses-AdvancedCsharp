using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public Player(string name, string @class)
        {
            Name = name;
            Class = @class;
            Rank = "Trial";
            Description = "n/a";
        }

        public Player(string name, string @class, string rank, string description)
        {
            Name = name;
            Class = @class;
            Rank = rank;
            Description = description;
        }
        //• Name: string
        //• Class: string
        //• Rank: string – "Trial" by default
        //• Description: string – "n/a" by default
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }


        public override string ToString()
        {
            StringBuilder sv = new StringBuilder();

            sv.AppendLine($"Player {this.Name}: {this.Class}");
            sv.AppendLine($"Rank: {this.Rank}");
            sv.AppendLine($"Description: {this.Description}");
            
            return sv.ToString();
        }
    }
}
