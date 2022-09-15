using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endproject
{
    public interface Iteam
    {
        void Add(Player player);
        void Remove(int playerid);
        Player GetPlayerById(int playerid);
        Player GetPlayerByName(string playername);
        List<Player> GetAllPlayers();
        
    }
    public class Player
    {
        // getting all player details
        private int _playerid;
        private string _playername;
        private int _playerage;
        public int Player_ID
        {
            get { return _playerid; }
            set { _playerid = value; }
        }
        public string Player_Name
        {
            get { return _playername; }
            set { _playername = value; }
        }
        public int Player_Age
        {
            get { return _playerage; }
            set { _playerage = value; }
        }
    }
    public class OneDayTeam : Player, Iteam
    {
        public static List<Player> Oneday = new List<Player>();
        public OneDayTeam()
        {
            Oneday.Capacity = 11;
        }
        public void Add(Player player)
        {
            Oneday.Add(player);
        }

        public List<Player> GetAllPlayers()
        {
            return Oneday;
        }
       

        public Player GetPlayerById(int playerid)
        {
            Player player = null;

            foreach (var item in Oneday)
            {
                if (item.Player_ID == playerid)
                {
                    player = item;
                    break;
                }
            }
            return player;

        }
        public Player GetPlayerByName(string playername)
        {
            Player player = null;

            foreach (var item in Oneday)
            {
                if (item.Player_Name == playername)
                {
                    player = item;

                    break;
                }
            }
            return player;


        }
        public void Remove(int playerid)
        {
            Player player = null;

            foreach (var item in Oneday)
            {
                if (item.Player_ID == playerid)
                {
                    Console.WriteLine("Player Removed successfully");
                    player = item;
                }
            }
            Oneday.Remove(player);
        }

       
    }
}