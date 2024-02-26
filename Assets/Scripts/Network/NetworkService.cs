using VContainer;

namespace Network
{
    public class NetworkService : INetworkService
    {
        [Inject] private readonly NetworkRoomHandler roomHandler;

        public void StartGame() => roomHandler.StartGame();
    }
}