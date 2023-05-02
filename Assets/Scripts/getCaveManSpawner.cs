using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class getCaveManSpawner : MonoBehaviour
{
    private static int temp;

    void Start()
    {
        temp = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int getBuildIndex()
    {
        return temp;
    }
}
