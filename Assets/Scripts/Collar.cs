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

    [SerializeField] private SceneName CurrentScene;

    // started as seperate scripts for every type of clothing but the maths manager means i can reduce it to three - one for each type

    public int CurrentCollar { get; set; }

    string collarKey = "Collar";

    private void Awake()
    {
        CurrentCollar = PlayerPrefs.GetInt(collarKey);
    }

    public void SetItem(int collar)
    {
        PlayerPrefs.SetInt(collarKey, collar);
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
            if (CurrentCollar == 0)
            {
                cuteOutift();
            }
            else if (CurrentCollar == 1)
            {
                cuteOutfitS();
            }
            else if (CurrentCollar == 2)
            {
                coolOutfit();
            }
            else if (CurrentCollar == 3)
            {
                coolOutfitS();
            }
            else if (CurrentCollar == 4)
            {
                smartOutfit();
            }
            else if (CurrentCollar == 5)
            {
                smartOutfitS();
            }
            else if (CurrentCollar == 6)
            {
                funOutfit();
            }
            else if (CurrentCollar == 7)
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

    [SerializeField] private SpriteRenderer CollarSprite;

    //changes it to the outfits referenced in the method name

    void cuteOutift()
    {
        CollarSprite.sprite = spriteArray[0];
        CutePoints = 100;
        CoolPoints = 15;
        SmartPoints = 15;
        FunPoints = 75;
        Name = "Flower collar";
        SetItem(0);
    }

    void cuteOutfitS()
    {
        CollarSprite.sprite = spriteArray[1];
        CutePoints = 100;
        CoolPoints = 15;
        SmartPoints = 15;
        FunPoints = 75;
        Name = "Flower collar";
        SetItem(1);
    }

    void coolOutfit()
    {
        CollarSprite.sprite = spriteArray[2];
        CutePoints = 30;
        CoolPoints = 100;
        SmartPoints = 74;
        FunPoints = 40;
        Name = "Bandana";
        SetItem(2);
    }

    void coolOutfitS()
    {
        CollarSprite.sprite = spriteArray[3];
        CutePoints = 30;
        CoolPoints = 100;
        SmartPoints = 74;
        FunPoints = 40;
        Name = "Bandana";
        SetItem(3);
    }

    void smartOutfit()
    {
        CollarSprite.sprite = spriteArray[4];
        CutePoints = 40;
        CoolPoints = 75;
        SmartPoints = 100;
        FunPoints = 15;
        Name = "Tie";
        SetItem(4);
    }

    void smartOutfitS()
    {
        CollarSprite.sprite = spriteArray[5];
        CutePoints = 40;
        CoolPoints = 75;
        SmartPoints = 100;
        FunPoints = 15;
        Name = "Tie";
        SetItem(5);
    }

    void funOutfit()
    {
        CollarSprite.sprite = spriteArray[6];
        CutePoints = 60;
        CoolPoints = 10;
        SmartPoints = 20;
        FunPoints = 100;
        Name = "Frills";
        SetItem(6);
    }

    void funOutfitS()
    {
        CollarSprite.sprite = spriteArray[7];
        CutePoints = 60;
        CoolPoints = 10;
        SmartPoints = 20;
        FunPoints = 100;
        Name = "Frills";
        SetItem(7);
    }

    void ReturnToDefault()
    {
        CollarSprite.sprite = null;
        CutePoints = 10;
        CoolPoints = 10;
        SmartPoints = 10;
        FunPoints = 10;
        Name = "N/A";
        SetItem(8);
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
        if (Input.GetKeyDown(KeyCode.H))
        {
            smartOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            funOutfit();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            funOutfitS();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ReturnToDefault();
        }
    }
}
