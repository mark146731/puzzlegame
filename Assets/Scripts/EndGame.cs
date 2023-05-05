using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    
    TheClipBoard clipBoard = new TheClipBoard();

    public GameObject prefabToInstantiate;

    public List<GameObject> gameObjects = new List<GameObject>(3);
    //element 0 is Solution1Holder
    //element 1 is Solution2Holder
    //element 2 is Solution3Holder
    private string[] tags = { "RockKey", "LampKey", "CrateKey" };
    //steps to success
    //
    private void Start()
    {
      
    }
    public void Update()
    {
        
    }

}

