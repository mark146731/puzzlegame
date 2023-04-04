using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public GameObject Rock;
    public GameObject PickUpText;
    public GameObject DropText;
    public Transform RockParent;

    void Start()
    {
        Rock.GetComponent<Rigidbody>().isKinematic = true;
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
        RockParent.DetachChildren();
        Rock.transform.eulerAngles = new Vector3(Rock.transform.position.x, Rock.transform.position.z, Rock.transform.position.y);
        Rock.GetComponent<Rigidbody>().isKinematic = false;
        Rock.GetComponent<MeshCollider>().enabled = true;
    }
    void EquipRock()
    {
        Rock.GetComponent<Rigidbody>().isKinematic = true;
        Rock.transform.position = RockParent.transform.position;
        Rock.transform.rotation = RockParent.transform.rotation;

        Rock.GetComponent<MeshCollider>().enabled = false;
        Rock.transform.SetParent(RockParent);

    }
    bool hasBeenUsed;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(hasBeenUsed == true)
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
        if(other.gameObject.tag == "Player")
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
