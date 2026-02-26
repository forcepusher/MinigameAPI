using UnityEngine;

namespace BananaParty.Minigame
{
    public interface IMinigame<TResult>
    {
        public AsyncOperation StartMinigame();

        public AsyncOperation AbortMinigame();

        public bool IsMinigameFinished { get; }

        public TResult Result { get; }
    }
}
