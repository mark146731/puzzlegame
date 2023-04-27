using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class TheClipBoard : MonoBehaviour
{
    public GameObject promptText;


    // Start is called before the first frame update

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            promptText.SetActive(true);
        }
    }
    void Start()
    {
        promptText.SetActive(false);

    }
    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            promptText.SetActive(false);
        }
    }

    void Update()
    {
        
    }
}
