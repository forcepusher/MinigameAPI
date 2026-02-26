using UnityEngine;

namespace BananaParty.Minigame
{
    public interface IMinigame<TPlayResult>
    {
        public AsyncOperation StartMinigame();

        public AsyncOperation AbortMinigame();

        public bool IsMinigameFinished { get; }

        public TPlayResult Result { get; }
    }
}
