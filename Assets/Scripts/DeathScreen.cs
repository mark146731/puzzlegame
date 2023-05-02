using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    int temp;
    public void Start()
    {
        temp = SceneManager.GetActiveScene().buildIndex;
    }

    public void RestartGame ()
    {
        SceneManager.LoadScene(temp);
    }

  public void ReturnMenu ()
    {
        SceneManager.LoadScene("Title");
    }
}