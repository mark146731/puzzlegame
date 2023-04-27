using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject Crate;
    public GameObject Rock;
    public GameObject Lamp;
    
    public  GameObject DropText;
    public GameObject PickUpText;

    public bool keyCrate;
    public bool keyRock;
    public bool keyLamp;

    // i want to randomize the order in which the boxes are placd. The hint must match the randomized order


   //if the object has been picked up check if DropText has been deleted and if so, then instantiate the object again. 
    
    public bool getkeyCrate()
    {
        return keyCrate;
    }
    public bool getKeyRock()
    {
        return keyRock;
    }
    public bool getKeyLamp()
    {
        return keyLamp;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CrateKey")
        {
            Destroy(other.gameObject);
            this.keyCrate = true;
        }
        else if (other.gameObject.tag == "RockKey")
        {
            Destroy(other.gameObject);
            this.keyRock = true;
        }
        else if (other.gameObject.tag == "LampKey")
        {
            Destroy(other.gameObject);
            this.keyLamp = true;
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
