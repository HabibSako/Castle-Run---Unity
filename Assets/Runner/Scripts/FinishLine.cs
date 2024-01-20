using UnityEngine;

namespace HyperCasual.Runner
{
    /// <summary>
    /// Ends the game on collision, forcing a win state.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    public class FinishLine : MonoBehaviour
    {
        [SerializeField] GameObject pauseMenu;
        const string k_PlayerTag = "Player";

        void OnTriggerEnter(Collider col)
        {
            if (col.CompareTag(k_PlayerTag))
            {
             
                Time.timeScale = 0f;

                HandleWin();
            }
        }

        // Handle winning logic
        void HandleWin()
        {
            Debug.Log("You won the game!");
            pauseMenu.SetActive(true);
        }
    }
}
