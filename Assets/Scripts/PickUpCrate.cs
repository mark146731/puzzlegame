using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCrate : MonoBehaviour
{
    //change sphere collider to 1
    //lamp box collider to 1,1.5,1
    //change crate box collider to 0.7,0.7,0.7
    
    public GameObject Stick;
    public GameObject PickUpText;
    public GameObject DropText;
    public Transform StickParent;

    FinishLevel test = new FinishLevel();
    private BoxCollider boxCollider;

    public Transform myChildObject;

    public void ResizeCollider(float x, float y, float z)
    {
        // Set the new size of the BoxCollider
        boxCollider.size = new Vector3(x, y, z);
    }
    private void Start()
    {
        Stick.GetComponent<Rigidbody>().isKinematic = true;
        PickUpText.SetActive(false);
        DropText.SetActive(false);
        boxCollider = GetComponent<BoxCollider>();

    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            DropText.SetActive(false);
            Drop();
        }
    }
    private void Drop()
    {
        Stick.transform.parent = null;
        Stick.transform.eulerAngles = new Vector3(Stick.transform.position.x, Stick.transform.position.z, Stick.transform.position.y);
        Stick.GetComponent<Rigidbody>().isKinematic = false;
        Stick.GetComponent<MeshCollider>().enabled = true;
        ResizeCollider(4f, 4f, 4f);

    }
    private void EquipRock()
    {
        ResizeCollider(0.7f, 0.7f, 0.7f);
        Stick.GetComponent<Rigidbody>().isKinematic = true;
        Stick.transform.position = StickParent.transform.position;
        Stick.transform.rotation = StickParent.transform.rotation;

        Stick.GetComponent<MeshCollider>().enabled = false;

        Stick.transform.SetParent(StickParent);

    }
    bool hasBeenUsed;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (hasBeenUsed == true)
            {
                PickUpText.SetActive(true);
            }
            else
            {
                PickUpText.SetActive(false);
                DropText.SetActive(true);
            }
            if (Input.GetKey(KeyCode.E))
            {
                hasBeenUsed = false;
                EquipRock();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            hasBeenUsed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
        DropText.SetActive(false);
    }
}
