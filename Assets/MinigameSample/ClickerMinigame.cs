using UnityEngine;
using UnityEngine.SceneManagement;

namespace BananaParty.Minigame.Sample
{
    public class ClickerMinigame : MonoBehaviour, IMinigame<int>
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
            return SceneManager.LoadSceneAsync(SceneName, LoadSceneMode.Additive);
        }

        public void OnClickerButtonClick()
        {
            _clickCount += 1;

            if (_clickCount >= ClicksToWin)
                _isGameFinished = true;
        }
    }
}
