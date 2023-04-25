using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hints : MonoBehaviour
{

    public GameObject HintFirstLevel;
    public GameObject SecondHintFirstLevel;
    public GameObject ThridHintFirstLevel;

    //public GameObject Player;
    public GameObject MaxHints;
    public GameObject keyImage1;
    public GameObject keyImage2;
    public GameObject keyImage3;

    private int counter = 0;
 



    private bool hasBeenUsedOnLevel = false;

    float startTime = 3f;
    float currentTime = 0f;



    void Start()
    {
        currentTime = startTime;
        HintFirstLevel.SetActive(false);
        SecondHintFirstLevel.SetActive(false);
        ThridHintFirstLevel.SetActive(false);

        MaxHints.SetActive(false);
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        
        if (currentTime < 0)
        {
            HintFirstLevel.SetActive(false);
            SecondHintFirstLevel.SetActive(false);
            restart();
            MaxHints.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if(hasBeenUsedOnLevel)
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
         

        }
    }

    public void FirstHint()
    {
        HintFirstLevel.SetActive(true);
        keyImage3.SetActive(false);

    }
    public void SecondHint()
    {

    }
    public void ThridHint()
    {
       
    }

    public void restart()
    {
        currentTime = startTime;
    }
}
