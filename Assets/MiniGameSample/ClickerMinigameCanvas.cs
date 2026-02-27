using UnityEngine;

namespace BananaParty.Minigame.Sample
{
    public class ClickerMinigameCanvas : MonoBehaviour
    {
        private const int ClicksToWin = 5;

        private int _clickCount = 0;
        private bool _isGameFinished = false;

        public void OnClickerButtonClick()
        {
            _clickCount += 1;

            if (_clickCount >= ClicksToWin)
                _isGameFinished = true;
        }
    }
}
