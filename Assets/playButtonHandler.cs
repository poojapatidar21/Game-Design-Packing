using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playButtonHandler : MonoBehaviour
{

    float currentTime = 0f;
    float startTime = 60f;
    [SerializeField] Text countdownText;

    bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayGame()
    {
        print("Game Start");
        currentTime = startTime;
        countdownText.text = currentTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            currentTime -= 1 * Time.deltaTime;
            string minutes = ((int)(currentTime / 60)).ToString();
            string seconds = ((int)(currentTime % 60)).ToString();
            if (minutes.Length == 1) minutes = "0" + minutes;
            if (seconds.Length == 1) seconds = "0" + seconds;
            string a = minutes + ":" + seconds;
            countdownText.text = a;
            if (currentTime <= 0)
            {
                GameOver();
            }
        }
    }
    void GameOver()
    {
        isGameOver = true;
        print("Game over");
    }
}
