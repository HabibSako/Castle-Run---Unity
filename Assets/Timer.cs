using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    [SerializeField] GameObject pauseMenu;

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            // game over
            timerText.color = Color.red;
            timerText.text = "Game Over";
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }

        
    }
}
