using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hints : MonoBehaviour
{

    public GameObject HintFirstLevel;
    //public GameObject Player;
    public GameObject MaxHints;
    public GameObject keyImage1;
    public GameObject keyImage2;
    public GameObject keyImage3;

 



    private bool hasBeenUsedOnLevel = false;

    float startTime = 3f;
    float currentTime = 0f;



    void Start()
    {
        currentTime = startTime;
        HintFirstLevel.SetActive(false);
        MaxHints.SetActive(false);
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime < 0)
        {
            HintFirstLevel.SetActive(false);
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
                hasBeenUsedOnLevel = true;
                restart();
                keyImage3.SetActive(false);
            }
        }
    }
    /*
    private void onTriggerEnter(Collision other)
    {
        if(other.gameObject.tag == "Rock)
            {
                
            }
        if(other.gameObject.tag == "Stick")
        {

        }
    }
    */


    public void restart()
    {
        currentTime = startTime;
    }
}
