using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject Ethel;
    public GameObject Honey;
    public GameObject Tangerine;

    [SerializeField] public Dog ChosenDog;

    public string currentDog = "Ethel";

    [SerializeField] private Button ButtonName;
    [SerializeField] private GameManager GameManager;

    public bool petPressed, playPressed, feedPressed, continueButton, cuteButton, coolButton, smartButton, funButton, switchTestButton = false;

    public void ButtonTest()
    {
        if (ButtonName.name == "Pet")
        {
            Debug.Log(message: "Pet Button Pressed");
            Debug.Log(message: "Current Dog is: " + currentDog);
            petPressed = !petPressed;
        }

        if (ButtonName.name == "Play")
        {
            Debug.Log(message: "Play Button Pressed");
            playPressed = !playPressed;
        }


        if (ButtonName.name == "Feed")
        {
            Debug.Log(message: "Feed Button Pressed");
            feedPressed = !feedPressed;
        }

        if (ButtonName.name == "Cute")
        {
            Debug.Log(ButtonName.name);
        }

        if (ButtonName.name == "Cool")
        {
            Debug.Log(ButtonName.name);
        }
        
        if (ButtonName.name == "Smart")
        {
            Debug.Log(ButtonName.name);
        }

        if (ButtonName.name == "Fun")
        {
            Debug.Log(ButtonName.name);
        }

        if (ButtonName.name == "Continue")
        {
            SceneManager.LoadScene("Home Scene");
        }

        else if (ButtonName.name == "Show")
        {
            Debug.Log(message: "Showtime Button Pressed");
            SceneManager.LoadScene("Fashion Show");
        }

    }

    public void ButtonTest2()
    {
        Debug.Log(message: "Button Pressed again");
    }
    public void Start()
    {
        Debug.Log(message: "Game Start");
    }
}
