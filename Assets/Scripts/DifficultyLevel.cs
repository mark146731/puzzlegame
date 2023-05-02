using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DifficultyLevel : MonoBehaviour
{
    public static string difficulty;

    public void Start()
    {

    }
    public void Update()
    {

    }
    
    
    public void setDifficultyLevelEasy()
    {
        difficulty = "Easy";
    }
    public void setDifficultyLevelNormal()
    {
        difficulty = "Normal";

    }
    public void setDifficultyLevelHard()
    {
        difficulty = "Hard";
    }
    public void setDifficultyLevelNull()
    {
        difficulty= "null";
    }
    public static string getDifficultLevel()
    {
        return difficulty;
    }
}
