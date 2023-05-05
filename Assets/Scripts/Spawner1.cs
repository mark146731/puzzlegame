using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject boardPrefab;
    private string[] tagValues = { "RockKey", "LampKey", "CrateKey" };
    //green is rock, white is lamp, and crate is red,
    // Start is called before the first frame update
    void Start()
    {
        TheClipBoard clipBoard = new TheClipBoard();
        List<int> list = clipBoard.getList();
        GameObject tempBoardPrefab = Instantiate(boardPrefab, transform.position, Quaternion.identity);
        
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 1)
                {
                    int pos = i;
                    string temp = tagValues[pos];
                    tempBoardPrefab.tag = temp;
                }
            }
        }
       
       
    }

