using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BananaParty.Minigame.Sample
{
    public class ClickerMinigame : IMinigame<int>
    {
        private const string SceneName = "ClickerMinigameScene";

        private ClickerMinigameCanvas _clickerMinigameCanvas;

        private int _clickCount = 0;
        private bool _isGameFinished = false;

        public bool IsMinigameFinished => _clickerMinigameCanvas ? _isGameFinished : false;

        public int MinigamePlayResult => _clickerMinigameCanvas ? _clickCount : 0;

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
            while (!loadingOperation.isDone)
                await Task.Yield();

            _clickerMinigameCanvas = Object.FindAnyObjectByType<ClickerMinigameCanvas>();
        }
    }
}
