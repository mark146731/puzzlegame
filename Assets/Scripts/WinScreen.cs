using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public void ReturnTitle ()
    {
        SceneManager.LoadScene("Title");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
