using UnityEngine;

namespace Player
{
    public class PlayerData
    {
        public readonly string playerName;

        public PlayerData()
        {
            playerName = $"Player {Random.Range(0, 9999)}";
        }
    }
}