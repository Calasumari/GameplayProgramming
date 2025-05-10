using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Main : MonoBehaviour
{
    public int CutePoints;
    public int CoolPoints;
    public int FunPoints;
    public int SmartPoints;
    public string Name;
    public string Type = "Main";

    [SerializeField] private SceneName CurrentScene;

    // started as seperate scripts for every type of clothing but the maths manager means i can reduce it to three - one for each type

    public int CurrentMain { get; set; }

    string mainKey = "Main";

    private void Awake()
    {
        CurrentMain = PlayerPrefs.GetInt(mainKey);
    }

    public void SetItem(int main)
    {
        PlayerPrefs.SetInt(mainKey, main);
    }


    // Start is called before the first frame update
    void Start()
    {
        if (CurrentScene.sceneName == "Home" | CurrentScene.sceneName == "Select"| CurrentScene.sceneName == "Wardrobe")
        {
            ReturnToDefault();
        }
        else
        {
            if (CurrentMain == 0)
            {
                cuteOutift();
            }
            else if (CurrentMain == 1)
            {
                cuteOutfitS();
            }
            else if(CurrentMain == 2)
            {
                coolOutfit();
            }
            else if(CurrentMain == 3)
            {
                coolOutfitS();
            }
            else if (CurrentMain == 4)
            {
                smartOutfit();
            }
            else if (CurrentMain == 5)
            {
                smartOutfitS();
            }
            else if (CurrentMain == 6)
            {
                funOutfit();
            }
            else if (CurrentMain == 7)
            {
                funOutfitS();
            }
            else
            {
                ReturnToDefault();
            }
        }
    }


    public Sprite[] spriteArray;

    [SerializeField] private SpriteRenderer MainSprite;

    //changes it to the outfits referenced in the method name 

    void cuteOutift()
    {
        MainSprite.sprite = spriteArray[0];
        CutePoints = 100;
        CoolPoints = 40;
        SmartPoints = 30;
        FunPoints = 75;
        Name = "Skirt and bow";
        SetItem(0);
    }

    void cuteOutfitS()
    {
        MainSprite.sprite = spriteArray[1];
        CutePoints = 100;
        CoolPoints = 40;
        SmartPoints = 30;
        FunPoints = 75;
        Name = "Skirt and bow";
        SetItem(1);
    }

    void coolOutfit()
    {
        MainSprite.sprite = spriteArray[2];
        CutePoints = 20;
        CoolPoints = 100;
        SmartPoints = 50;
        FunPoints = 10;
        Name = "Black skirt";
        SetItem(2);
    }

    void coolOutfitS()
    {
        MainSprite.sprite = spriteArray[3];
        CutePoints = 20;
        CoolPoints = 100;
        SmartPoints = 50;
        FunPoints = 10;
        Name = "Black skirt";
        SetItem(3);
    }

    void smartOutfit()
    {
        MainSprite.sprite = spriteArray[4];
        CutePoints = 30;
        CoolPoints = 40;
        SmartPoints = 100;
        FunPoints = 10;
        Name = "Smart Skirt";
        SetItem(4);
    }

    void smartOutfitS()
    {
        MainSprite.sprite = spriteArray[5];
        CutePoints = 30;
        CoolPoints = 40;
        SmartPoints = 100;
        FunPoints = 10;
        Name = "Smart Skirt";
        SetItem(5);
    }

    void funOutfit()
    {
        MainSprite.sprite = spriteArray[6];
        CutePoints = 75;
        CoolPoints = 15;
        SmartPoints = 10;
        FunPoints = 100;
        Name = "Clown Suit";
        SetItem(6);
    }

    void funOutfitS()
    {
        MainSprite.sprite = spriteArray[7];
        CutePoints = 75;
        CoolPoints = 15;
        SmartPoints = 10;
        FunPoints = 100;
        Name = "Clown Suit";
        SetItem(7);

    }

    void ReturnToDefault()
    {
        MainSprite.sprite = null;
        CutePoints = 10;
        CoolPoints = 10;
        SmartPoints = 10;
        FunPoints = 10;
        Name = "N/A";
        SetItem(8);
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
