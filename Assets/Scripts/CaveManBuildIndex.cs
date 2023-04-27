using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CaveManBuildIndex : MonoBehaviour
{
    public static int temp;

    void Start()
    {
       
        temp = SceneManager.GetActiveScene().buildIndex;
       
    }
    public static int getBuildIndex()
    {
        return temp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
