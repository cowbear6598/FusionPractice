using Fusion;
using Network;
using Player;
using SoapTools.SceneTransition;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Main
{
    public class MainLifetimeScope : LifetimeScope
    {
        [SerializeField] private SceneScriptableObject sceneAsset;

        protected override void Configure(IContainerBuilder builder)
        {
            RegisterScene(builder);
            RegisterData(builder);
            RegisterNetwork(builder);
        }

        private static void RegisterScene(IContainerBuilder builder)
        {
            builder.Register<SceneLoadHandler>(Lifetime.Singleton)
                   .AsSelf();
            builder.Register<SceneStateHandler>(Lifetime.Singleton)
                   .AsSelf();
            builder.RegisterComponentInHierarchy<SceneView>()
                   .AsSelf();
            builder.Register<SceneService>(Lifetime.Singleton)
                   .AsImplementedInterfaces()
                   .AsSelf();
        }

        private void RegisterData(IContainerBuilder builder)
        {
            builder.Register<PlayerData>(Lifetime.Singleton)
                   .AsSelf();
        }

        private void RegisterNetwork(IContainerBuilder builder)
        {
            builder.RegisterInstance(sceneAsset);
            builder.Register<NetworkRoomHandler>(Lifetime.Singleton)
                   .AsSelf();
            builder.Register<NetworkSceneHandler>(Lifetime.Singleton)
                   .AsSelf();
            builder.Register<NetworkService>(Lifetime.Singleton)
                   .AsImplementedInterfaces()
                   .AsSelf();
            builder.RegisterComponentInHierarchy<NetworkRunner>()
                   .AsSelf();
        }
    }
}