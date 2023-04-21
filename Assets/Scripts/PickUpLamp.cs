using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpLamp : MonoBehaviour
{
    public GameObject Lamp;
    public GameObject PickUpText;
    public GameObject DropText;
    public Transform LampParent;

    void Start()
    {
        Lamp.GetComponent<Rigidbody>().isKinematic = true;
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
        LampParent.DetachChildren();
        Lamp.transform.eulerAngles = new Vector3(Lamp.transform.position.x, Lamp.transform.position.z, Lamp.transform.position.y);
        Lamp.GetComponent<Rigidbody>().isKinematic = false;
        Lamp.GetComponent<MeshCollider>().enabled = true;
    }
    void EquipRock()
    {
        Lamp.GetComponent<Rigidbody>().isKinematic = true;
        Lamp.transform.position = LampParent.transform.position;
        Lamp.transform.rotation = LampParent.transform.rotation;

        Lamp.GetComponent<MeshCollider>().enabled = false;

        Lamp.transform.SetParent(LampParent);

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
