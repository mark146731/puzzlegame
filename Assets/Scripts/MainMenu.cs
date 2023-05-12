using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void StartGame ()
    {
        SceneManager.LoadScene("Directions");
    }
    public void StartCaveMan()
    {
        SceneManager.LoadScene("CaveMan");
    }

  public void QuitGame()
    {
        Application.Quit();
    }
}
