using Cysharp.Threading.Tasks;
using Fusion;
using SoapTools.SceneTransition;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;

namespace Network
{
    public class NetworkSceneHandler
    {
        [Inject] private readonly NetworkRunner runner;
        [Inject] private readonly ISceneService sceneService;

        public async UniTask LoadScene(string sceneName)
        {
            Debug.LogError($"Server: {runner.IsServer}");
            Debug.LogError($"Client: {runner.IsClient}");
            Debug.LogError($"Master Client: {runner.IsSharedModeMasterClient}");

            await sceneService.PreLoadScene();

            if (runner.IsSharedModeMasterClient)
            {
                await runner.LoadScene(SceneRef.FromPath(sceneName), LoadSceneMode.Additive);
            }

            await sceneService.UnloadAllScenes();
            sceneService.PostScene();
        }
    }
}