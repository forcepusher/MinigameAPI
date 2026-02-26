using UnityEngine;

namespace BananaParty.Minigame.Sample
{
    public class ClickerMinigame : MonoBehaviour, IMinigame<int>
    {
        public bool IsMinigameFinished => throw new System.NotImplementedException();

        public int MinigamePlayResult => throw new System.NotImplementedException();

        public AsyncOperation AbortMinigame() => throw new System.NotImplementedException();
        public AsyncOperation StartMinigame() => throw new System.NotImplementedException();

        
    }
}
