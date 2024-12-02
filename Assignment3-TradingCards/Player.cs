using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment3_TradingCards
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string PhotoPath { get; set; }
        public int GamesPlayed { get; set; }
        public int Touchdowns { get; set; }
        public int Yards { get; set; }
        public int Rating { get; set; }

        public static List<Player> Players { get; } = new List<Player>
        {
            // Kansas City Chiefs Players
            new Player
            {
                Name = "Travis Kelce",
                Team = "Kansas City Chiefs",
                PhotoPath = "travis_kelce.jpg",
                GamesPlayed = 120,
                Touchdowns = 80,
                Yards = 8000,
                Rating = 95
            },
            new Player
            {
                Name = "Patrick Mahomes",
                Team = "Kansas City Chiefs",
                PhotoPath = "patrick_mahomes.jpg",
                GamesPlayed = 85,
                Touchdowns = 65,
                Yards = 6000,
                Rating = 98
            },
            new Player
            {
                Name = "Chris Jones",
                Team = "Kansas City Chiefs",
                PhotoPath = "chris_jones.jpg",
                GamesPlayed = 105,
                Touchdowns = 5,
                Yards = 200,
                Rating = 90
            },
            new Player
            {
                Name = "Isiah Pacheco",
                Team = "Kansas City Chiefs",
                PhotoPath = "isiah_pacheco.jpg",
                GamesPlayed = 20,
                Touchdowns = 10,
                Yards = 800,
                Rating = 85
            },

            // Tennessee Titans Players
            new Player
            {
                Name = "Derrick Henry",
                Team = "Tennessee Titans",
                PhotoPath = "derrick_henry.jpg",
                GamesPlayed = 90,
                Touchdowns = 75,
                Yards = 9000,
                Rating = 92
            },
            new Player
            {
                Name = "Ryan Tannehill",
                Team = "Tennessee Titans",
                PhotoPath = "ryan_tannehill.jpg",
                GamesPlayed = 105,
                Touchdowns = 50,
                Yards = 4000,
                Rating = 87
            },
            new Player
            {
                Name = "Kevin Byard",
                Team = "Tennessee Titans",
                PhotoPath = "kevin_byard.jpg",
                GamesPlayed = 110,
                Touchdowns = 3,
                Yards = 50,
                Rating = 88
            },
            new Player
            {
                Name = "Treylon Burks",
                Team = "Tennessee Titans",
                PhotoPath = "treylon_burks.jpg",
                GamesPlayed = 15,
                Touchdowns = 5,
                Yards = 450,
                Rating = 83
            },

            // Miami Dolphins Players
            new Player
            {
                Name = "Tyreek Hill",
                Team = "Miami Dolphins",
                PhotoPath = "tyreek_hill.jpg",
                GamesPlayed = 95,
                Touchdowns = 60,
                Yards = 8000,
                Rating = 94
            },
            new Player
            {
                Name = "Tua Tagovailoa",
                Team = "Miami Dolphins",
                PhotoPath = "tua_tagovailoa.jpg",
                GamesPlayed = 50,
                Touchdowns = 40,
                Yards = 3500,
                Rating = 89
            },
            new Player
            {
                Name = "Jaylen Waddle",
                Team = "Miami Dolphins",
                PhotoPath = "jaylen_waddle.jpg",
                GamesPlayed = 40,
                Touchdowns = 20,
                Yards = 2000,
                Rating = 88
            },
            new Player
            {
                Name = "Jalen Ramsey",
                Team = "Miami Dolphins",
                PhotoPath = "jalen_ramsey.jpg",
                GamesPlayed = 115,
                Touchdowns = 5,
                Yards = 0,
                Rating = 90
            }
        };

        public Player()
        {
            Name = "New Player";
            Team = "New Team";
            PhotoPath = "default_image.jpg";
            GamesPlayed = 0;
            Touchdowns = 0;
            Yards = 0;
            Rating = 0;
        }

        public string GetValidPhotoPath()
        {
            return File.Exists(PhotoPath) ? PhotoPath : "default_image.jpg";
        }
    }
}
