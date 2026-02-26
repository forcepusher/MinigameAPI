using UnityEngine;

namespace BananaParty.MiniGame
{
    public interface IMinigame<TResult>
    {
        public AsyncOperation StartMiniGame();

        public AsyncOperation AbortMiniGame();

        public bool IsMiniGameFinished { get; }

        public TResult Result { get; }
    }
}
