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

    [SerializeField] private SceneName CurrentScene;

    // started as seperate scripts for every type of clothing but the maths manager means i can reduce it to three - one for each type

    public int CurrentAcc { get; set; }

    string accKey = "Acc";

    private void Awake()
    {
        CurrentAcc = PlayerPrefs.GetInt(accKey);
    }

    public void SetItem(int accessory)
    {
        PlayerPrefs.SetInt(accKey, accessory);
    }


    // Start is called before the first frame update
    void Start()
    {
        if (CurrentScene.sceneName == "Home" | CurrentScene.sceneName == "Select" | CurrentScene.sceneName == "Wardrobe")
        {
            ReturnToDefault();
        }
        else
        {
            if (CurrentAcc == 0)
            {
                cuteOutift();
            }
            else if (CurrentAcc == 1)
            {
                cuteOutfitS();
            }
            else if (CurrentAcc == 2)
            {
                coolOutfit();
            }
            else if (CurrentAcc == 3)
            {
                coolOutfitS();
            }
            else if (CurrentAcc == 4)
            {
                smartOutfit();
            }
            else if (CurrentAcc == 5)
            {
                smartOutfitS();
            }
            else if (CurrentAcc == 6)
            {
                funOutfit();
            }
            else if (CurrentAcc == 7)
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

    [SerializeField] private SpriteRenderer AccessorySprite;

    //changes it to the outfits referenced in the method name

    void cuteOutift()
    {
        AccessorySprite.sprite = spriteArray[0];
        CutePoints = 100;
        CoolPoints = 10;
        SmartPoints = 10;
        FunPoints = 75;
        Name = "Wand";
        SetItem(0);
    }

    void cuteOutfitS()
    {
        AccessorySprite.sprite = spriteArray[1];
        CutePoints = 100;
        CoolPoints = 10;
        SmartPoints = 10;
        FunPoints = 75;
        Name = "Wand";
        SetItem(1);
    }

    void coolOutfit()
    {
        AccessorySprite.sprite = spriteArray[2];
        CutePoints = 10;
        CoolPoints = 100;
        SmartPoints = 10;
        FunPoints = 20;
        Name = "Cool chain";
        SetItem(2);
    }

    void coolOutfitS()
    {
        AccessorySprite.sprite = spriteArray[3];
        CutePoints = 10;
        CoolPoints = 100;
        SmartPoints = 10;
        FunPoints = 20;
        Name = "Cool chain";
        SetItem(3);
    }

    void smartOutfit()
    {
        AccessorySprite.sprite = spriteArray[4];
        CutePoints = 20;
        CoolPoints = 20;
        SmartPoints = 100;
        FunPoints = 10;
        Name = "Bag";
        SetItem(4);
    }

    void smartOutfitS()
    {
        AccessorySprite.sprite = spriteArray[5];
        CutePoints = 10;
        CoolPoints = 20;
        SmartPoints = 100;
        FunPoints = 10;
        Name = "Bag";
        SetItem(5);
    }

    void funOutfit()
    {
        AccessorySprite.sprite = spriteArray[6];
        CutePoints = 50;
        CoolPoints = 10;
        SmartPoints = 10;
        FunPoints = 100;
        Name = "Balls";
        SetItem(6);
    }

    void funOutfitS()
    {
        AccessorySprite.sprite = spriteArray[7];
        CutePoints = 50;
        CoolPoints = 10;
        SmartPoints = 10;
        FunPoints = 100;
        Name = "Balls";
        SetItem(7);
    }

    void ReturnToDefault()
    {
        AccessorySprite.sprite = null;
        CutePoints = 0;
        CoolPoints = 0;
        SmartPoints = 0;
        FunPoints = 0;
        Name = "N/A";
        SetItem(8);
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
