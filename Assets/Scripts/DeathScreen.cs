using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    int temp;
    DifficultyLevel difficultyLevel = new DifficultyLevel();
    getCaveManSpawner index = new getCaveManSpawner();
    public void Start()
    {
        temp = index.getBuildIndex();
    }

    public void RestartGame ()
    {
        SceneManager.LoadScene(temp);
    }

  public void ReturnMenu ()
    {
        SceneManager.LoadScene("Title");
        difficultyLevel.setDifficultyLevelNull();
    }
}