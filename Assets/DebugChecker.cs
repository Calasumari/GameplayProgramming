using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChecker : MonoBehaviour
{
    [SerializeField] SceneName currentScene;
    [SerializeField] Main currentMain;
    [SerializeField] Collar currentCollar;
    [SerializeField] Accessory currentAccessory;
    [SerializeField] Dog currentDog;

    public int dog;
    public int score;
    public int main;
    public int collar;
    public int accessory;

    string dogKey = "Dog";
    string scoreKey = "Score";
    string mainKey = "Main";
    string collarKey = "Collar";
    string accKey = "Acc";

    void Update()
    {
        dog = PlayerPrefs.GetInt(dogKey);
        score = PlayerPrefs.GetInt(scoreKey);
        main = PlayerPrefs.GetInt(mainKey);
        collar = PlayerPrefs.GetInt(collarKey);
        accessory = PlayerPrefs.GetInt(accKey);

        if (Input.GetKeyUp(KeyCode.Alpha0))
        {
            Debug.Log("Current Scene :" + currentScene.sceneName);

            if (currentScene.sceneName == "Home")
            {
                Debug.Log("No Issues. Selected Dog:" + currentDog.name);
            }

            Debug.Log(currentDog.Name + ", " + dog);
            Debug.Log(currentMain.Name + ", " + main);
            Debug.Log(currentCollar.Name + ", " + collar);
            Debug.Log(currentAccessory.Name + ", " + accessory);
            Debug.Log("Current Score is: " + score);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Current Scene :" + currentScene.sceneName);
    }

  
}
