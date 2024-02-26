using Fusion;
using UnityEngine;

namespace Network
{
    public class NetworkView : MonoBehaviour
    {
        private NetworkRunner runner;

        private void Awake()
        {
            runner = FindFirstObjectByType<NetworkRunner>();
        }

        public void StartGame(StartGameArgs startGameArgs)
        {
            runner.StartGame(startGameArgs);
        }
    }
}