using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accessory : MonoBehaviour
{
    public int CutePoints;
    public int CoolPoints;
    public int FunPoints;
    public int SmartPoints;
    public string Name;
    public string Type;

    enum AccesoryName { Placeholder1, Placeholder2 };

    // started as seperate scripts for every type of clothing but the maths manager means i can reduce it to one for each type


    // Start is called before the first frame update
    void Start()
    {
        AccessorySprite.sprite = null;
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

    [SerializeField] private SpriteRenderer AccessorySprite;
    [SerializeField] private Button DogSwitchTest;
    [SerializeField] private Dog Ethel;
    [SerializeField] private SpriteRenderer DogSprite;

    //changes it to the outfits referenced in the method name

    void cuteOutift()
    {
        AccessorySprite.sprite = spriteArray[0];
        CutePoints = 100;
        CoolPoints = 10;
        SmartPoints = 10;
        FunPoints = 75;
        Name = "Wand";
    }

    void cuteOutfitS()
    {
        AccessorySprite.sprite = spriteArray[1];
        CutePoints = 100;
        CoolPoints = 10;
        SmartPoints = 10;
        FunPoints = 75;
        Name = "Wand";
    }

    void coolOutfit()
    {
        AccessorySprite.sprite = spriteArray[2];
        CutePoints = 10;
        CoolPoints = 100;
        SmartPoints = 10;
        FunPoints = 20;
        Name = "Cool chain";
    }

    void coolOutfitS()
    {
        AccessorySprite.sprite = spriteArray[3];
        CutePoints = 10;
        CoolPoints = 100;
        SmartPoints = 10;
        FunPoints = 20;
        Name = "Cool chain";
    }

    void smartOutfit()
    {
        AccessorySprite.sprite = spriteArray[4];
        CutePoints = 20;
        CoolPoints = 20;
        SmartPoints = 100;
        FunPoints = 10;
        Name = "Bag";
    }

    void smartOutfitS()
    {
        AccessorySprite.sprite = spriteArray[6];
        CutePoints = 10;
        CoolPoints = 20;
        SmartPoints = 100;
        FunPoints = 10;
        Name = "Bag";
    }

    void funOutfit()
    {
        AccessorySprite.sprite = spriteArray[7];
        CutePoints = 50;
        CoolPoints = 10;
        SmartPoints = 10;
        FunPoints = 100;
        Name = "Balls";
    }

    void funOutfitS()
    {
        AccessorySprite.sprite = spriteArray[7];
        CutePoints = 50;
        CoolPoints = 10;
        SmartPoints = 10;
        FunPoints = 100;
        Name = "Balls";
    }

    void ReturnToDefault()
    {
        AccessorySprite.sprite = null;
        CutePoints = 0;
        CoolPoints = 0;
        SmartPoints = 0;
        FunPoints = 0;
        Name = "N/A";
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            cuteOutift();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            cuteOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            coolOutfit();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            coolOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            smartOutfit();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            smartOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            funOutfit();
        }
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            funOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ReturnToDefault();
        }
    }
}
