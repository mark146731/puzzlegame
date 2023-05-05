using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ObjectGrabbable : MonoBehaviour
{
    private Rigidbody objectRigidbody;
    private Transform objectGrabPointTransform;
    public GameObject text;

    public GameObject temp1;
    public GameObject temp2;
    public GameObject temp3;


    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();        
    }
    public void Grab(Transform objectGrabPointTransform)
    {
        this.objectGrabPointTransform = objectGrabPointTransform;
        string tag = temp1.gameObject.tag;
        if (tag == "CrateKey")
        {
            tag = "[Red]";
        }
        string tag1 = temp2.gameObject.tag;
        {
            if (tag1 == "LampKey")
            {
                tag = "[White]";

            }
            string tag3 = temp3.gameObject.tag;
            if (tag3 == "RockKey")
            {
                tag = "[Green]";
            }
            text.GetComponent<TMP_Text>().text = tag;
            text.SetActive(true);
            objectRigidbody.useGravity = false;
        }
    }
    public void Drop()
    {
        this.objectGrabPointTransform = null;
        objectRigidbody.useGravity = true;
        text.SetActive(false);
    }
    private void FixedUpdate()
    {
        if(objectGrabPointTransform != null)
        {
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, objectGrabPointTransform.position, Time.deltaTime * lerpSpeed);
            objectRigidbody.MovePosition(newPosition);
        }
    }
    public void Start()
    {
        text.SetActive(false);
    }
}
