using UnityEngine;
using UnityEngine.SceneManagement;

public class Directions : MonoBehaviour
{
   public void Continue ()
    {
        SceneManager.LoadScene("DifficultyMenu");
    }
}
