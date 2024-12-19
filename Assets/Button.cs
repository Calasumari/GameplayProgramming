using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private Button ButtonName;

    public void ButtonTest()
    {
        if (ButtonName.name == "Pet")
        {
            Debug.Log(message: "Pet Button Pressed");
        }
        else if (ButtonName.name == "Play")
        {
            Debug.Log(message: "Play Button Pressed");
        }
        else
        {
            Debug.Log(message: "Feed Button Pressed");
        }

    }

    public void ButtonTest2()
    {
        Debug.Log(message: "Button Pressed again");
    }
}
