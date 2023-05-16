using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject[] originalObjects;
    public string[] correspondingTags;
    private bool[] isColliding;

    void Start()
    {
        isColliding = new bool[originalObjects.Length];
    }

    void Update()
    {
        // Check each original object against its corresponding tag
        for (int i = 0; i < originalObjects.Length; i++)
        {
            GameObject original = originalObjects[i];
            string tag = correspondingTags[i];

            Collider[] colliders = Physics.OverlapBox(original.transform.position, original.transform.localScale / 2);
            bool foundMatchingTag = false;

            // Check each collider that's overlapping with the original object's bounds
            foreach (Collider collider in colliders)
            {
                if (collider.CompareTag(tag))
                {
                    foundMatchingTag = true;
                    break;
                }
            }

            // Set the flag for whether the original object is colliding with its corresponding tag
            isColliding[i] = foundMatchingTag;
        }

        // Check if all original objects are colliding with their corresponding tags
        bool allColliding = true;
        foreach (bool colliding in isColliding)
        {
            if (!colliding)
            {
                allColliding = false;
                break;
            }
        }

        // If all original objects are colliding with their corresponding tags, switch scenes
        if (allColliding)
        {
            //LoadNextScene();
        }
    }
    private void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }



}
