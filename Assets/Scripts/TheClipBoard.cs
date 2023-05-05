using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class TheClipBoard : MonoBehaviour
{
    public GameObject promptText;
    public GameObject Hud;

    public  TMP_Text KeyText1;
    public TMP_Text KeyText2;
    public TMP_Text KeyText3;

    public int arraySize = 3; // The size of the array to be generated
    public static List<int> numbers; // The list to store the generated numbers

    private bool inRange;


    // Start is called before the first frame update

   
    public void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            promptText.SetActive(true);
            inRange = true;
        }
        
    }
    void Start()
    {
        // Initialize the list with the specified size
        numbers = new List<int>(arraySize);

        // Generate a list of the numbers 1, 2, 3
        List<int> originalNumbers = new List<int>() { 1, 2, 3 };

        // Shuffle the original list using the Fisher-Yates algorithm
        for (int i = originalNumbers.Count - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            int temp = originalNumbers[i];
            originalNumbers[i] = originalNumbers[j];
            originalNumbers[j] = temp;
        }

        // Copy the shuffled numbers into the list
        for (int i = 0; i < arraySize; i++)
        {
            numbers.Add(originalNumbers[i]);
        }
        string myString1 = numbers[0].ToString();
        KeyText1.SetText(myString1);
        string myString2 = numbers[1].ToString();
        KeyText2.SetText(myString2);
        string myString3 = numbers[2].ToString();
        KeyText3.SetText(myString3);
        promptText.SetActive(false);
        Hud.SetActive(false);
    }
    public  List<int> getList()
    {
        return numbers;
    }
    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            promptText.SetActive(false);
            inRange = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && inRange)
        {
            Hud.SetActive(true);
            promptText.SetActive(false);
        }
        else if(!inRange)
        {
            Hud.SetActive(false);
        }
    }
}
