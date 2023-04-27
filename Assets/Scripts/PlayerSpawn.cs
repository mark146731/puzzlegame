using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{


    public static string temp = DifficultyLevel.getDifficultLevel();
    
    public boolean playerHasReturnedToTitle;

    //easy,medium,hard
    private float[] xPosList = new float[3] { 51.2f,75.9f,14.1f};
    private float[] yPosList = new float[3] { 5,4.261f,10.739f };
    private float[] zPosList = new float[3] { 78.596f,56.271f,70.245f};

    public void Start()
    {
        if(temp == "Easy")
        {
            transform.position = new Vector3(xPosList[0], yPosList[0], zPosList[0]);
        }
        if (temp == "Normal")
        {
            transform.position = new Vector3(xPosList[1], yPosList[1], zPosList[1]);
        }
        if (temp == "Hard")
        {
            transform.position = new Vector3(xPosList[2], yPosList[2], zPosList[2]);
        }
    }
    public void Update()
    {
        if (playerHasReturnedToTitle)
        {

        }
    }
}
