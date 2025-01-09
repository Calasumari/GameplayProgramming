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

    //changes it to the outfits referenced in the method name

    void cuteOutift()
    {
        CollarSprite.sprite = spriteArray[0];
    }

    void cuteOutfitS()
    {
        CollarSprite.sprite = spriteArray[1];
    }

    void coolOutfit()
    {
        CollarSprite.sprite = spriteArray[2];
    }

    void coolOutfitS()
    {
        CollarSprite.sprite = spriteArray[3];
    }

    void smartOutfit()
    {
        CollarSprite.sprite = spriteArray[4];
    }

    void smartOutfitS()
    {
        CollarSprite.sprite = spriteArray[6];
    }

    void funOutfit()
    {
        CollarSprite.sprite = spriteArray[7];
    }

    void funOutfitS()
    {
        CollarSprite.sprite = spriteArray[7];
    }

    void ReturnToDefault()
    {
        CollarSprite.sprite = null;
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
