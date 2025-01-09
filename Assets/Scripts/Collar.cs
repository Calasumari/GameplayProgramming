using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collar : MonoBehaviour
{
    public int CutePoints;
    public int CoolPoints;
    public int FunPoints;
    public int SmartPoints;
    public string Name;
    public string Type = "Collar";

    enum collarName { Placeholder1, Placeholder2};

    // started as seperate scripts for every type of clothing but the maths manager means i can reduce it to three - one for each type


        // Start is called before the first frame update
    void Start()
    {
        CollarSprite.sprite = null;
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

    [SerializeField] private SpriteRenderer CollarSprite;
    [SerializeField] private Button DogSwitchTest;
    [SerializeField] private Dog Ethel;
    [SerializeField] private SpriteRenderer DogSprite;

    //changes it to the outfits referenced in the method name

    void cuteOutift()
    {
        CollarSprite.sprite = spriteArray[0];
        CutePoints = 100;
        CoolPoints = 15;
        SmartPoints = 15;
        FunPoints = 75;
        Name = "Flower collar";
    }

    void cuteOutfitS()
    {
        CollarSprite.sprite = spriteArray[1];
        CutePoints = 100;
        CoolPoints = 15;
        SmartPoints = 15;
        FunPoints = 75;
        Name = "Flower collar";
    }

    void coolOutfit()
    {
        CollarSprite.sprite = spriteArray[2];
        CutePoints = 30;
        CoolPoints = 100;
        SmartPoints = 74;
        FunPoints = 40;
        Name = "Bandana";
    }

    void coolOutfitS()
    {
        CollarSprite.sprite = spriteArray[3];
        CutePoints = 30;
        CoolPoints = 100;
        SmartPoints = 74;
        FunPoints = 40;
        Name = "Bandana";
    }

    void smartOutfit()
    {
        CollarSprite.sprite = spriteArray[4];
        CutePoints = 40;
        CoolPoints = 75;
        SmartPoints = 100;
        FunPoints = 15;
        Name = "Tie";
    }

    void smartOutfitS()
    {
        CollarSprite.sprite = spriteArray[6];
        CollarSprite.sprite = spriteArray[4];
        CutePoints = 40;
        CoolPoints = 75;
        SmartPoints = 100;
        FunPoints = 15;
        Name = "Tie";
    }

    void funOutfit()
    {
        CollarSprite.sprite = spriteArray[7];
        CutePoints = 60;
        CoolPoints = 10;
        SmartPoints = 20;
        FunPoints = 100;
        Name = "Frills";
    }

    void funOutfitS()
    {
        CollarSprite.sprite = spriteArray[7];
        CutePoints = 60;
        CoolPoints = 10;
        SmartPoints = 20;
        FunPoints = 100;
        Name = "Frills";
    }

    void ReturnToDefault()
    {
        CollarSprite.sprite = null;
        CutePoints = 10;
        CoolPoints = 10;
        SmartPoints = 10;
        FunPoints = 10;
        Name = "N/A";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cuteOutift();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            cuteOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            coolOutfit();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            coolOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            smartOutfit();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            smartOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            funOutfit();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            funOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ReturnToDefault();
        }
    }
}
