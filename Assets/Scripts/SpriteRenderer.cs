using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    /* public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeSprite();
        }
    } */

    public Sprite[] spriteArray;

    [SerializeField] private SpriteRenderer CurrentObject;
    [SerializeField] private Button DogSwitchTest;
    [SerializeField] private Dog Ethel;

    void ChangeSprite()
    {
        /* if (Ethel.Size == "big")
        {
            CurrentObject.sprite = spriteArray[1]
        } */
        CurrentObject.sprite = spriteArray[1];

    }

    void ChangeSprite2()
    {
        CurrentObject.sprite = spriteArray[2];
    }

    void ChangeSprite3()
    {
        CurrentObject.sprite = spriteArray[0];
    }

    /* private void Update()
    {
        if (Input.GetButtonDown(q))
        {
            ChangeSprite();
        }
        else if (Input.GetButtonDown("w"))
        {
            ChangeSprite2();
        }
        else if (Input.GetButtonDown("e"))
        {
            ChangeSprite3();
        }
    } */
}
