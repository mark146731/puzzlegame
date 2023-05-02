using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public List<string> tagsList = new List<string> { "RockKey", "LampKey", "CrateKey" };
        
    public GameObject objectPrefab;
    
    void Start()
    {
        
        for (int i = 0; i < tagsList.Count; i++)
        {
            string randomTag = tagsList[Random.Range(0, tagsList.Count)];
            //int index = tagsList.FindIndex(a => a.Contains(randomTag));
            //tagsList.RemoveAt(index);
            GameObject newObject = Instantiate(objectPrefab, transform.position, Quaternion.identity);
            newObject.tag = randomTag;
        }
    }
}

