using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject Crate;
    public GameObject Rock;
    public GameObject Lamp;
    public GameObject DropText;
    public GameObject PickUpText;

    public bool text;


   //if the object has been picked up check if DropText has been deleted and if so, then instantiate the object again. 
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CrateKey")
        {
            Destroy(other.gameObject);
            Destroy(DropText);
        }
        else if (other.gameObject.tag == "RockKey")
        {
            Destroy(other.gameObject);
            Destroy(DropText);
        }
        else if (other.gameObject.tag == "LampKey")
        {
            Destroy(other.gameObject);
            Destroy(DropText);
        }
    }
    void Update()
    {
        if(Crate == null && Rock == null && Lamp == null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Instantiate(DropText);
    }

}
