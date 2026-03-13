using UnityEngine;

namespace BananaParty.Minigame
{
    public interface IMinigame<TPlayResult>
    {
        /// <summary>
        /// Use this layer as your main layer to avoid conflicts with the main scene.
        /// Light settings Culling Mask must be enabled only for this layer and exclusively.
        /// </summary>
        public int MainMinigameLayer { get => 30; }
        /// <summary>
        /// Use this layer for your own custom minigame logic that might need an extra layer.
        /// </summary>
        public int AdditionalMinigameLayer { get => 31; }

        public AsyncOperation StartMinigame(Camera mainSceneCamera);

        public AsyncOperation EndMinigame();

        public bool IsMinigameFinished { get; }

        public TPlayResult MinigamePlayResult { get; }
    }
}
