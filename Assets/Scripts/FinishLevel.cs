using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject crate;
    public GameObject lamp;
    public GameObject rock;

    public static int count;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(crate.tag))
        {
            count++;
        }
        if (other.gameObject.CompareTag(lamp.tag))
        {
            count++;
        }
        if (other.gameObject.CompareTag(rock.tag))
        {
            count++;
        }
    }

    private void Update()
    {
        if(count == 3)
        {
            SceneManager.LoadScene("WinScren");
        }
    }
    private void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }



}
