using Network;
using Player;
using VContainer;
using VContainer.Unity;

namespace Main
{
    public class MainLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<PlayerData>(Lifetime.Singleton)
                   .AsSelf();

            RegisterNetwork(builder);
        }

        private static void RegisterNetwork(IContainerBuilder builder)
        {
            builder.Register<NetworkRoomHandler>(Lifetime.Singleton)
                   .AsSelf();
            builder.Register<NetworkService>(Lifetime.Singleton)
                   .AsImplementedInterfaces()
                   .AsSelf();
        }
    }
}