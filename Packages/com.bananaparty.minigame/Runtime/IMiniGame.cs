namespace BananaParty.MiniGame
{
    public interface IMiniGame
    {
        public AsyncOperation StartMiniGame();

        public AsyncOperation AbortMiniGame();

        public bool IsMiniGameFinished { get; }

        public int Score { get; }
    }
}
