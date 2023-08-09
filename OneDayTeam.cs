using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppCricketTeam
{
    public class OneDayTeam:ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }

        public void Add(Player player)
        {
            if (oneDayTeam.Count < 11)
            {
                oneDayTeam.Add(player);
                Console.WriteLine($"Player {player.PlayerName} added to the team.");
            }
            else
            {
                Console.WriteLine("Team is full. Cannot add more players.");
            }
        }

        public void Remove(int playerId)
        {
            Player playerToRemove = oneDayTeam.FirstOrDefault(player => player.PlayerId == playerId);
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine($"Player {playerToRemove.PlayerName} removed from the team.");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.FirstOrDefault(player => player.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.FirstOrDefault(player => player.PlayerName == playerName);
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
