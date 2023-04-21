using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public Transform player;
    private Vector3 dir = new Vector3();
    void Start()
    {

    }
    void Update()
    {
        dir.z = player.eulerAngles.y;
        transform.localEulerAngles = dir;   
    }
}
