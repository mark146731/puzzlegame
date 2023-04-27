using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private string[] values = {"RockKey","LampKey","CrateKey"};


    public GameObject[] boxes = new GameObject[3];
    
    
    public string[] objectTagsToFind;
    private int touchingCount = 0;


     void Start()
    {
        for(int i = 0; i < boxes.Length; i++)
        {
            boxes[i].tag = getRandValue();
        }
        for(int i=0; i < values.Length; i++)
        {
            Debug.Log(values[i]);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (boxes[0].tag == other.tag)
        {
            touchingCount++;
        }
        else
        {
            touchingCount = 0;
        }
        if (boxes[1].tag == other.tag)
        {
            touchingCount++;
        }
        else
        {
            touchingCount = 0;
        }
        if (boxes[2].tag == other.tag)
        {
            touchingCount++;
        }
        else
        {
            touchingCount = 0;
        }
    }
    private void Update()
    {
        if(touchingCount == 3)
        {
            SceneManager.LoadScene("Medieval");
        }
    }



    private string getRandValue()
    {
        int randomIndex = Random.Range(0, values.Length);
        string randomValue = values[randomIndex];

        for (int i = randomIndex; i < values.Length - 1; i++)
        {
            values[i] = values[i + 1];
        }
        values[values.Length - 1] = " ";
        System.Array.Resize(ref values, values.Length - 1);
        return randomValue;
    }



}

