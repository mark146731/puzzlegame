using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCrate : MonoBehaviour
{
    public GameObject Stick;
    public GameObject PickUpText;
    public GameObject DropText;
    public Transform StickParent;

    void Start()
    {
        Stick.GetComponent<Rigidbody>().isKinematic = true;
        PickUpText.SetActive(false);
        DropText.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            DropText.SetActive(false);
            Drop();
        }
    }
    void Drop()
    {
        StickParent.DetachChildren();
        Stick.transform.eulerAngles = new Vector3(Stick.transform.position.x, Stick.transform.position.z, Stick.transform.position.y);
        Stick.GetComponent<Rigidbody>().isKinematic = false;
        Stick.GetComponent<MeshCollider>().enabled = true;
    }
    void EquipRock()
    {
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
