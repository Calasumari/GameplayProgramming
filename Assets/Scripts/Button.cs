using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] private Button ButtonName;

    public string petButton = "Not Pressed";
    public string playButton = "Not Pressed";
    public string feedButton = "Not Pressed";
    public string ethelButton = "Not Pressed";
    public string honeyButton = "Not Pressed";
    public string tanButton = "Not Pressed";
    public string continueButton = "Not Pressed";

    public void ButtonTest()
    {
        if (ButtonName.name == "Pet")
        {
            Debug.Log(message: "Pet Button Pressed");
            if (petButton == "Not Pressed")
            {
                petButton = "Pressed";
            }
            else
            {
                petButton = "NotPressed";
            }
        }
        else if (ButtonName.name == "Play")
        {
            Debug.Log(message: "Play Button Pressed");
            if (playButton == "Not Pressed")
            {
                playButton = "Pressed";
            }
            else
            {
                playButton = "Not Pressed";

            }
        }
        else if (ButtonName.name == "Feed")
        {
            Debug.Log(message: "Feed Button Pressed");
            if (playButton == "Not Pressed")
            {
                feedButton = "Pressed";
            }
            else
            {
                feedButton = "Not Pressed";
            }
        }
        else if (ButtonName.name == "Ethel")
        {
            Debug.Log(message: "Ethel Button Pressed");
            if (playButton == "Not Pressed")
            {
                ethelButton = "Pressed";
            }
            else
            {
                ethelButton = "Not Pressed";
            }
        }
        else if (ButtonName.name == "Honey")
        {
            Debug.Log(message: "Honey Button Pressed");
            if (playButton == "Not Pressed")
            {
                honeyButton = "Pressed";
            }
            else
            {
                honeyButton = "Not Pressed";
            }
        }
        else if (ButtonName.name == "Tangerine")
        {
            Debug.Log(message: "Tangerine Button Pressed");
            if (playButton == "Not Pressed")
            {
                tanButton = "Pressed";
            }
            else
            {
                tanButton = "Not Pressed";
            }
        }

        else if (ButtonName.name == "Continue")
        {
            Debug.Log(message: "Continue Button Pressed");
            SceneManager.LoadScene("Home Scene");
        }

        else if (ButtonName.name == "Show")
        {
            Debug.Log(message: "Showtime Button Pressed");
            SceneManager.LoadScene("Fashion Show");
        }
        else
        {
            Debug.Log(message: "New Button Pressed");
            if (feedButton == "Not Pressed")
            {
                feedButton = "Pressed";
            }
            else
            {
                feedButton = "Not Pressed";
            }
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
