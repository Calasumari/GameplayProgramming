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
    public string Type;

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

    //changes it to the outfits referenced in the method name 

    void cuteOutift()
    {
        MainSprite.sprite = spriteArray[0];
    }

    void cuteOutfitS()
    {
        MainSprite.sprite = spriteArray[1];
    }

    void coolOutfit()
    {
        MainSprite.sprite = spriteArray[2];
    }

    void coolOutfitS()
    {
        MainSprite.sprite = spriteArray[3];
    }

    void smartOutfit()
    {
        MainSprite.sprite = spriteArray[4];
    }

    void smartOutfitS()
    {
        MainSprite.sprite = spriteArray[6];
    }

    void funOutfit()
    {
        MainSprite.sprite = spriteArray[7];
    }

    void funOutfitS()
    {
        MainSprite.sprite = spriteArray[7];
    }

    void ReturnToDefault()
    {
        MainSprite.sprite = null;
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
