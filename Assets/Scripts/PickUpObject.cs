using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public Transform objectParent;
    public Transform objectHoldPosition;

    private bool isHoldingObject = false;
    private Rigidbody objectRigidbody;

    void Start()
    {
        objectRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!isHoldingObject && Input.GetKeyDown(KeyCode.E))
        {
            Pickup();
        }
        else if (isHoldingObject && Input.GetKeyDown(KeyCode.E))
        {
            Drop();
        }
    }

    void Pickup()
    {
        transform.SetParent(objectHoldPosition);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        objectRigidbody.isKinematic = true;
        isHoldingObject = true;
    }

    void Drop()
    {
        transform.SetParent(objectParent);
        transform.position = objectHoldPosition.position;
        objectRigidbody.isKinematic = false;
        isHoldingObject = false;
    }
}
