using SoapTools.SceneTransition;
using UnityEngine;
using VContainer;

namespace Main
{
    public class Bootstrap : MonoBehaviour
    {
        [Inject] private readonly ISceneService sceneService;

        private void Start()
        {
            sceneService.LoadScene(0);
        }
    }
}