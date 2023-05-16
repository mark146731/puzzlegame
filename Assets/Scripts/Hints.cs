using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Hints : MonoBehaviour
{
    //public GameObject Player;
    public GameObject MaxHints;
    
    public GameObject keyImage1;
    public GameObject keyImage2;
    public GameObject keyImage3;

    
    
    public TMP_Text hintText;

    private int counter = 0;

    public ArrayList  buttonPressNum;
    private string[] hints = { "Food, Potion, Skull", " Read the book and pay attention to the colors", "Place each object in the barrell that matches its color","" };
    private string[] hints2 = {};

    public float hintDuration = 5f;

    // Define the number of hints that have been displayed so far
    private int hintCount = 0;


    //the user presess H and the first hint appears. The text appears for 5 seconds and the key image gets deleted
    // the user presses H again and the 2nd hint appears. The same thing happens
    //the user presses H and the 3rd hint appears
    //the user presses H and the max hints appears

    private bool hasBeenUsedOnLevel = false;

    float startTime = 3f;
    float currentTime = 0f;

    private bool test;


    void Start()
    {
        // Initialize the button press count ArrayList

        currentTime = startTime;
        //make the text inactive for all the hints
        //HintFirstLevel.SetActive(false);
        //SecondHintFirstLevel.SetActive(false);
        //ThridHintFirstLevel.SetActive(false);
        //MaxHints.SetActive(false);
    }
    void Update()
    {
     
        //when the user presses H
        if (Input.GetKeyDown(KeyCode.H))
        {
            hintText.enabled = true;
            if (hintCount < hints.Length)
            {
                hintText.text = hints[hintCount];
                hintCount++;
            }
            if(hintCount == 1)
            {
                keyImage3.SetActive(false);
            }
            if (hintCount == 2)
            {
                keyImage2.SetActive(false);
            }
            if (hintCount == 3)
            {
                keyImage1.SetActive(false);
            }
            if(hintCount == 4)
            {
                hintText.text = "Maximum Hints Reached";
            }
            
            StartCoroutine(HideHintText());
            if (test)
            {
                // If all hints have been displayed, show the final text
                hintText.text = "You have reached the end of the hints!";
            }
            /*
            if (hasBeenUsedOnLevel)
            {
                MaxHints.SetActive(true);
                restart();
            }
            else 
            {
                HintFirstLevel.SetActive(true);
                restart();
                hasBeenUsedOnLevel |= true;
                keyImage3.SetActive(false);
                counter = 1;
            }
            */


        }
    }
    IEnumerator HideHintText()
    {
        // Wait for the specified duration
        yield return new WaitForSeconds(hintDuration);

        // Hide the hint text
        hintText.enabled = false;
    }
    public void restart()
    {
        currentTime = startTime;
    }
}
