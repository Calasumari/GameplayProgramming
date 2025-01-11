using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.UIElements;

public class MathsManager : MonoBehaviour
{
    [SerializeField] private Main SkirtandBow;
    [SerializeField] private Dog Honey;
    [SerializeField] private Dog Ethel;
    [SerializeField] private Dog Tangerine;
    [SerializeField] private Main Main;
    [SerializeField] private Collar Collar;
    [SerializeField] private Accessory Accessory;

    [SerializeField] private Button Pet;
    [SerializeField] private Button Play;
    [SerializeField] private Button Feed;
    [SerializeField] private Button CuteShow;
    [SerializeField] private Button CoolShow;
    [SerializeField] private Button SmartShow;
    [SerializeField] private Button FunShow;

    [SerializeField] private SceneName CurrentScene;
    public int mainP;
    public int collarP;
    public int bonus;
    public int finalScore;

    public string[] showTypes = { "Cute", "Cool", "Smart", "Cute" };


    public string tempShowType = "Smart";


    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(message: MainPoints());
        if (CurrentScene.sceneName == "Show")
        {
            MainPoints();
            CollarPoints();
            AccessoryBonus();
            Debug.Log(MainPoints());
            Debug.Log(CollarPoints());
            Debug.Log(AccessoryBonus());
            SetScore(FinalScore());
        }
        if (CurrentScene.sceneName == "Home")
        {
            SetScore(0);
        }

    }


    //setting the score for other variables to be able to access it with data persistence

    
    string scoreKey = "Score";

    public int scoreIndex = 0;

    public int CurrentScore { get; set; }

    private void Awake()
    {              
        
        CurrentScore = PlayerPrefs.GetInt(scoreKey);
    }

    public void SetScore(int score)
    {
        PlayerPrefs.SetInt(scoreKey, score);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (CurrentScene.sceneName == "Home")
        {
            if (Pet.petPressed | Pet.playPressed | Pet.feedPressed)
            {
                Debug.Log(message: "Points are " + MainPoints() + ".");
                Debug.Log(message: "Points are " + CollarPoints() + ".");
                Debug.Log(message: "Bonus is " + AccessoryBonus() + ".");
                Debug.Log(message: "Final Points are " + FinalScore() + ".");
                Pet.petPressed = false;
                Pet.playPressed = false;
                Pet.feedPressed = false;

            }
        }
    }

    public int MainPoints()
    {
        int addPoints;
        if (tempShowType == "Cute")
        {
            double cute = Main.CutePoints * 1.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            return addPoints;
        }

        else if (tempShowType == "Cool")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 1.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            return addPoints;
        }

        else if (tempShowType == "Fun")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 1.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            return addPoints;
        }

        else if (tempShowType == "Smart")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 1.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            return addPoints;
        }

        else
        {
            Debug.Log(message: "Show Type not found");
            return 0;
        }
    }

    public int CollarPoints()
    {
        int addPoints;
        if (tempShowType == "Cute")
        {
            double cute = Main.CutePoints * 1.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            return addPoints;
        }

        else if (tempShowType == "Cool")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 1.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            return addPoints;
        }

        else if (tempShowType == "Fun")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 1.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            return addPoints;
        }

        else if (tempShowType == "Smart")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 1.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            return addPoints;
        }

        else
        {
            Debug.Log(message: "Show Type not found");
            return 0;
        }
    }

    public double AccessoryBonus()
    {
        int addPoints;
        if (tempShowType == "Cute")
        {
            double cute = Main.CutePoints * 1.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            
        }

        else if (tempShowType == "Cool")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 1.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            
        }

        else if (tempShowType == "Fun")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 1.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            
        }

        else if (tempShowType == "Smart")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 1.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            
        }

        else
        {
            Debug.Log(message: "Show Type not found");
            return 0;
        }

        addPoints = addPoints / 100;

        return addPoints;
    }

    public int FinalScore()
    {
        double finalPoints = MainPoints() + CollarPoints() * AccessoryBonus();
        int score;
        score = Convert.ToInt32(finalPoints);
        return score;
    }
}
