using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    /* private static Button instance;
    public static Button Instance
    {
        get
        {
            if (instance == null) instance = GameObject.FindObjectOfType<Button>();
            return instance;
        }
    } */

    public GameObject Ethel;
    public GameObject Honey;
    public GameObject Tangerine;

    public string currentDog = "Ethel";

    [SerializeField] private Button ButtonName;
    [SerializeField] private GameManager GameManager;

    public bool petPressed, playPressed, feedPressed, ethelButton, honeyButton, tanButton, continueButton = false;

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


        if (ButtonName.name == "Ethel")
        {
            GameManager.Instance.selectedDog = Ethel;
            Debug.Log(message: "Ethel button pressed");
            currentDog = "Ethel";
        }


        if (ButtonName.name == "Honey")
        {
            Debug.Log(message: "Honey Button Pressed");
            GameManager.Instance.selectedDog = Honey;
            honeyButton = !honeyButton;
            currentDog = "Honey";
        }

        if (ButtonName.name == "Tangerine")
        {
            Debug.Log(message: "Tangerine Button Pressed");
            GameManager.Instance.selectedDog = Tangerine;
            tanButton = !tanButton;
            currentDog = "Tangerine";
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

    /* private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }

    /*public void HideButton()
    {

    }
   
    public void ReturnButton()
    {
        if (ButtonName.name == "Continue")
        {
            X
        }
    }*/
    public void ButtonTest2()
    {
        Debug.Log(message: "Button Pressed again");
    }
    public void Start()
    {
        Debug.Log(message: "Game Start");
    }
}
