using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level3counter : MonoBehaviour
{
	public float currentTime = 0f;
	float startTime = 80f;
	public GameObject timeUp;
	public GameObject main;
	bool isGameOver = false;
	[SerializeField] Text countdownText;

	void Start()
	{
		currentTime = startTime;
		timeUp.SetActive(false);
	}
	public void StartUp()
	{
		currentTime = startTime;
		timeUp.SetActive(false);
		isGameOver = false;
	}

	public void PlayGame()
	{
		print("Game Start");
		currentTime = startTime;
	}

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
		timeUp.SetActive(true);
		main.GetComponent<containerObjects>().GameOver();

	}
}
