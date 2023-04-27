using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public void Start()
    {

    }

    public void RestartGame ()
    {
        int curr = CaveManBuildIndex.getBuildIndex();
        SceneManager.LoadScene(curr);
    }

  public void ReturnMenu ()
    {
        SceneManager.LoadScene("Title");
    }
}