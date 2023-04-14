using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    public bool playerStarted = false;
    float startingTime;
    public string temp = DifficultyLevel.getDifficultLevel();
    
    [SerializeField] TMP_Text countdownText;

    void Start()
    {
        if(temp == "Hard")
        {
            startingTime = 30f;
            playerStarted = true;
        }
        else if(temp == "Normal")
        {
            startingTime = 60f;
            playerStarted = true;
        }
        else if(temp == "Easy")
        {
            startingTime = 90f;
            playerStarted = true;

        }
        currentTime = startingTime;
    }
    public void Update()
    {
        currentTime -= 1 * Time.deltaTime;
       countdownText.text = currentTime.ToString("0");
        if(currentTime <= 0 && playerStarted)
        {
            currentTime = 0;
            SceneManager.LoadScene("DeathScreen");

        }

    }
} 
