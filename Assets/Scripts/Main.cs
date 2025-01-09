using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public int CutePoints;
    public int CoolPoints;
    public int FunPoints;
    public int SmartPoints;
    public string Name;
    public string Type = "Main";

    // started as seperate scripts for every clothing but the maths manager means i can reduce it to one
    // all the code already uses "cute clothing" in scripts so i won't change the name


    // Start is called before the first frame update
    void Start()
    {
        MainSprite.sprite = null;
    }

    // Update is called once per frame
  

    public double PointsCalculation()
    {
        //might bit be needed, here as backup only
        double Cute = CutePoints * 1.2;
        double Cool = CoolPoints * 0.2;
        double Fun = FunPoints * 0.2;
        double Smart = SmartPoints * 0.2;

        return (Cute + Cool + Fun + Smart);
    }

    public Sprite[] spriteArray;

    [SerializeField] private SpriteRenderer MainSprite;
    [SerializeField] private Button DogSwitchTest;
    [SerializeField] private Dog Ethel;
    [SerializeField] private SpriteRenderer DogSprite;

    //changes it to the outfits referenced in the method name 

    void cuteOutift()
    {
        MainSprite.sprite = spriteArray[0];
        CutePoints = 100;
        CoolPoints = 40;
        SmartPoints = 30;
        FunPoints = 75;
        Name = "Skirt and bow";
    }

    void cuteOutfitS()
    {
        MainSprite.sprite = spriteArray[1];
        CutePoints = 100;
        CoolPoints = 40;
        SmartPoints = 30;
        FunPoints = 75;
        Name = "Skirt and bow";
    }

    void coolOutfit()
    {
        MainSprite.sprite = spriteArray[2];
        CutePoints = 20;
        CoolPoints = 100;
        SmartPoints = 50;
        FunPoints = 10;
        Name = "Black skirt";
    }

    void coolOutfitS()
    {
        MainSprite.sprite = spriteArray[3];
        CutePoints = 20;
        CoolPoints = 100;
        SmartPoints = 50;
        FunPoints = 10;
        Name = "Black skirt";
    }

    void smartOutfit()
    {
        MainSprite.sprite = spriteArray[4];
        CutePoints = 30;
        CoolPoints = 40;
        SmartPoints = 100;
        FunPoints = 10;
        Name = "Smart Skirt";
    }

    void smartOutfitS()
    {
        MainSprite.sprite = spriteArray[6];
        CutePoints = 30;
        CoolPoints = 40;
        SmartPoints = 100;
        FunPoints = 10;
        Name = "Smart Skirt";
    }

    void funOutfit()
    {
        MainSprite.sprite = spriteArray[7];
        CutePoints = 75;
        CoolPoints = 15;
        SmartPoints = 10;
        FunPoints = 100;
        Name = "Clown Suit";
    }

    void funOutfitS()
    {
        MainSprite.sprite = spriteArray[7];
        CutePoints = 75;
        CoolPoints = 15;
        SmartPoints = 10;
        FunPoints = 100;
        Name = "Clown Suit";

    }

    void ReturnToDefault()
    {
        MainSprite.sprite = null;
        CutePoints = 10;
        CoolPoints = 10;
        SmartPoints = 10;
        FunPoints = 10;
        Name = "N/A";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            cuteOutift();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            cuteOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            coolOutfit();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            coolOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            smartOutfit();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            smartOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            funOutfit();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            funOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ReturnToDefault();
        }
    }
}
