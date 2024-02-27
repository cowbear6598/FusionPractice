using Fusion;
using SoapTools.SceneTransition;
using UnityEngine;
using VContainer;

namespace Network
{
    public class NetworkRoomHandler
    {
        [Inject] private readonly NetworkRunner       runner;
        [Inject] private readonly NetworkSceneHandler sceneHandler;
        [Inject] private readonly ISceneService       sceneService;

        public async void StartGame()
        {
            runner.ProvideInput = true;

            var startGameArgs = new StartGameArgs {
                GameMode     = GameMode.Shared,
                SessionName  = "room",
                SceneManager = runner.GetComponent<NetworkSceneManagerDefault>(),
            };

            await runner.StartGame(startGameArgs);
            await sceneHandler.LoadScene("Game");
        }
    }
}