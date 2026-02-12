using System.Collections.Generic;
using LuckySpin.Models;

namespace LuckySpin.ViewModels
{
    public class PlayersChoice
    {
        public Player Player { get; set; }
        // Players to populate the dropdown
        public List<Player> Players { get; set; } = new List<Player>();
        // Games to display in the "Best Previous Games" table
        public List<Game> Games { get; set; } = new List<Game>();
        // Selected player id from the dropdown
        public int SelectedPlayerId { get; set; }

    }
}