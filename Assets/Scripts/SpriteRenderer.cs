using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public Sprite[] spriteArray;

    [SerializeField] private SpriteRenderer CurrentObject;
    [SerializeField] private SpriteRenderer Main;
    [SerializeField] private SpriteRenderer Collar;
    [SerializeField] private SpriteRenderer Accessory;
    [SerializeField] private Button DogSwitchTest;
    [SerializeField] private Dog Ethel;

    void ChangeSprite()
    {
        //changes it to honey
        CurrentObject.sprite = spriteArray[1];
    }

    void ChangeSprite2()
    {
        //Changes it to Tangerine + Small Cute Outfit
        CurrentObject.sprite = spriteArray[2];
        
    }

    void ChangeSprite3()
    {
        //Changes it to Ethel
        CurrentObject.sprite = spriteArray[0];
        
    }

    void cuteOutift()
    {
        Main.sprite = spriteArray[0];
        Collar.sprite = spriteArray[0];
        Accessory.sprite = spriteArray[0];
    }

    void cuteOutfitS()
    {
        Main.sprite = spriteArray[1];
        Collar.sprite = spriteArray[1];
        Accessory.sprite = spriteArray[1];
    }

    void coolOutfit()
    {
        Main.sprite = spriteArray[2];
        Collar.sprite = spriteArray[2];
        Accessory.sprite = spriteArray[2];
    }

    void coolOutfitS()
    {
        Main.sprite = spriteArray[3];
        Collar.sprite = spriteArray[3];
        Accessory.sprite = spriteArray[3];
    }

    void smartOutfit()
    {
        Main.sprite = spriteArray[4];
        Collar.sprite = spriteArray[4];
        Accessory.sprite = spriteArray[4];
    }

    void smartOutfitS()
    {
        Main.sprite = spriteArray[6];
        Collar.sprite = spriteArray[6];
        Accessory.sprite = spriteArray[6];
    }

    void funOutfit()
    {
        Main.sprite = spriteArray[7];
        Collar.sprite = spriteArray[7];
        Accessory.sprite = spriteArray[7];
    }

    void funOutfitS()
    {
        Main.sprite = spriteArray[7];
        Collar.sprite = spriteArray[7];
        Accessory.sprite = spriteArray[7];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeSprite();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ChangeSprite2();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeSprite3();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            cuteOutift();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            cuteOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            coolOutfit();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            coolOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            smartOutfit();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            smartOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            funOutfit();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            funOutfitS();
        }
    } 
}
