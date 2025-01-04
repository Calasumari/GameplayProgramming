using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.UIElements;

public class MathsManager : MonoBehaviour
{
    [SerializeField] private CuteClothing SkirtandBow;
    [SerializeField] private Dog Honey;
    [SerializeField] private Dog Ethel;
    [SerializeField] private Dog Tangerine;
    [SerializeField] private CuteClothing Main;
    [SerializeField] private CuteClothing Collar;
    [SerializeField] private CuteClothing Accessory;

    [SerializeField] private Button Pet;
    [SerializeField] private Button Play;
    [SerializeField] private Button Feed;

    public string[] showTypes = { "Cool", "Cute", "Fun", "Smart" };

    

    //public System.Random random = new System.Random();
    //int showSelection = random.Next(0,4);

    public string tempShowType = "Smart";


    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(message: MainPoints());

    }

    // Update is called once per frame
    void Update()
    {
        // if ((Pet.petButton == "Pressed")|(Play.playButton == "Pressed")|(Feed.feedButton == "Pressed")) 
        if (Pet.petPressed | Pet.playPressed | Pet.feedPressed)
        {
            Debug.Log(message: "Points are " + MainPoints() + ".");
            Debug.Log(message: "Points are " + CollarPoints() + ".");
            Debug.Log(message: "Bonus is " + AccessoryBonus() + ".");
            Pet.petPressed = false;
            Pet.playPressed = false;
            Pet.feedPressed = false;

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
}
