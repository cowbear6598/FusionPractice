using Fusion;
using VContainer;

namespace Network
{
    public class NetworkRoomHandler
    {
        [Inject] private readonly NetworkView view;

        public void StartGame()
        {
            var startGameArgs = new StartGameArgs {
                GameMode    = GameMode.Shared,
                SessionName = "RoomName",
            };
            
            view.StartGame(startGameArgs);
        }
    }
}