using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FirstDoorSolution : MonoBehaviour
{
    // Start is called before the first frame update

     public GameObject test;
    public GameObject test2;
    public GameObject test3;
    public  int counter;


    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == test.tag)
        {
            counter += 1;
        }
        if(other.gameObject.tag == test2.tag)
        {
            counter += 1;

        }
        if (other.gameObject.tag == test3.tag)
        {
            counter += 1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(counter == 3)
        {
            SceneManager.LoadScene("Medieval");
        }   
    }
}
