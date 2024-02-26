using Network;
using UnityEngine;
using VContainer;

namespace MenuScene
{
    public class UI_Menu : MonoBehaviour
    {
        [Inject] private readonly INetworkService networkService;

        public void Button_Start()
        {
            networkService.StartGame();
        }
    }
}