using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour
{
    [SerializeField] private SpriteRenderer opponentSprite;
    [SerializeField] private Dog CurrentDog;

    public string Name;

    public Sprite[] spriteArray;
    // Start is called before the first frame update
    void Start()
    {
        if (CurrentDog.Name == "Ethel")
        {
            if (Name == "Opponent1")
            {
                opponentSprite.sprite = spriteArray[1];
            }
            else
            {
                opponentSprite.sprite = spriteArray[2];

            }
        }
        if (CurrentDog.Name == "Tangerine")
        {
            if (Name == "Opponent1")
            {
                opponentSprite.sprite = spriteArray[0];
            }
            else
            {
                opponentSprite.sprite = spriteArray[1];

            }
        }
        else
        {
            if (Name == "Opponent1")
            {
                opponentSprite.sprite = spriteArray[2];
            }
            else
            {
                opponentSprite.sprite = spriteArray[1];

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
