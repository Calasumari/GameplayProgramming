using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public GameObject DogObject;

    public string Name;
    public string Breed;
    public string Colour;
    public string Size;
    public int Age;
    public double Friendship;

    string dogKey = "Dog";

    public int CurrentDog { get; set; }

    private void Awake()
    {
        CurrentDog = PlayerPrefs.GetInt(dogKey);
    }

    public void SetDog(int dog)          
    {
        PlayerPrefs.SetInt(dogKey, dog);
    }

    public Dog(string DogName, string DogBreed, string DogColour, string DogSize, int DogAge, double DogFriendship)
    {
        Name = DogName;
        Breed = DogBreed;
        Colour = DogColour;
        Size = DogSize;
        Age = DogAge;
        Friendship = DogFriendship;
    }

    Dog Ethel = new Dog("Ethel", "Akita", "Black and White", "big", 3, 0.00);
    Dog Honey = new Dog("Honey", "Golden retriver", "Gold", "big", 3, 0.00);
    Dog Tangerine = new Dog("Tangerine", "Corgi", "Orange", "small", 2, 0.00);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Current Dog is " + CurrentDog);
        if (CurrentDog == 0)
        {
            ChangeSprite3();
        }
        else if (CurrentDog == 1)
        {
            ChangeSprite();
        }
        else if (CurrentDog == 2)
        {
            ChangeSprite2();
        }
    }

    public Sprite[] spriteArray;

    [SerializeField] private SpriteRenderer CurrentObject;
    [SerializeField] private Button DogSwitchTest;

    void ChangeSprite()
    {
        //changes it to honey
        //if playerprefs.dog == 1
        CurrentObject.sprite = spriteArray[1];
        Name = "Honey";
        Breed = "Golden Retriever";
        Colour = "Gold";
        Size = "big";
        Age = 2;
        Friendship = 0.00;
    }

    void ChangeSprite2()
    {
        //Changes it to Tangerine
        //if playerprefs.dog == 2
        CurrentObject.sprite = spriteArray[2];
        Name = "Tangerine";
        Breed = "Corgi";
        Colour = "Orange";
        Size = "small";
        Age = 2;
        Friendship = 0.00;

    }

    void ChangeSprite3()
    {
        //Changes it to Ethel
        //if playerprefs.dog == 0
        CurrentObject.sprite = spriteArray[0];
        Name = "Ethel";
        Breed = "Akita";
        Colour = "Black and white";
        Size = "big";
        Age = 2;
        Friendship = 0.00;

    }

    void ReturnToDefault()
    {
        CurrentObject.sprite = spriteArray[0];
        Name = "Ethel";
        Breed = "Akita";
        Colour = "Black and white";
        Size = "big";
        Age = 2;
        Friendship = 0.00;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ChangeSprite();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ChangeSprite2();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ChangeSprite3();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ReturnToDefault();
        }
    }
}
