using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BananaParty.Minigame.Sample
{
    public class ClickerMinigame : IMinigame<int>
    {
        private const string SceneName = "ClickerMinigameScene";
        private const int ClicksToWin = 5;

        private int _clickCount = 0;
        private bool _isGameFinished = false;

        public bool IsMinigameFinished => _isGameFinished;

        public int MinigamePlayResult => _clickCount;

        public AsyncOperation EndMinigame()
        {
            return SceneManager.UnloadSceneAsync(SceneName);
        }

        public AsyncOperation StartMinigame()
        {
            AsyncOperation loadingOperation = SceneManager.LoadSceneAsync(SceneName, LoadSceneMode.Additive);
            GatherSceneReferences(loadingOperation);
            return loadingOperation;
        }

        private async void GatherSceneReferences(AsyncOperation loadingOperation)
        {
            while (_isGameFinished)
            {
                await Task.Yield();
            }
        }
    }
}
