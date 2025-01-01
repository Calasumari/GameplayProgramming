using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private Button ButtonName;

    public string petButton = "Not Pressed";
    public string playButton = "Not Pressed";
    public string feedButton = "Not Pressed";

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
        else
        {
            Debug.Log(message: "Feed Button Pressed");
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

    public void ButtonTest2()
    {
        Debug.Log(message: "Button Pressed again");
    }
}
