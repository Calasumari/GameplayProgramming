using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dog : MonoBehaviour
{

    [SerializeField] private SceneName currentScene;
    public GameObject DogObject;

    public string Name;
    public string Breed;
    public string Colour;
    public string Size;
    public int Age;
    public double Friendship;

    public int dogIndex = 0;

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

        int dognumber = CurrentDog;
        CurrentObject.sprite = spriteArray[dognumber];

        Debug.Log("Awake:" + SceneManager.GetActiveScene().name);

    }

    public Sprite[] spriteArray;

    [SerializeField] private SpriteRenderer CurrentObject;

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

    void ChangeSprite()
    {
        //changes it to honey
        //if playerprefs.dog == 1
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
        Name = "Tangerine";
        Breed = "Corgi";
        Colour = "Orange";
        Size = "small";
        Age = 2;
        Friendship = 0.00;

    }

    void ReturnToDefault()
    {
        Name = "Ethel";
        Breed = "Akita";
        Colour = "Black and white";
        Size = "big";
        Age = 2;
        Friendship = 0.00;
    }


    private void Update()
    {

        //old way of doing this 

        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    ChangeSprite();
        //}
        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    ChangeSprite2();
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    ChangeSprite3();
        //}
        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    ReturnToDefault();
        //}
        if (currentScene.sceneName == "Select")
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (dogIndex >= spriteArray.Length) return;
                dogIndex++;
                ChangeDogSprite(dogIndex);
                SetDog(dogIndex);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (dogIndex <= 0) return;
                dogIndex--;
                ChangeDogSprite(dogIndex);
                SetDog(dogIndex);
            }
        }
        
    }

    private void ChangeDogSprite(int i)
    {
        if (i < spriteArray.Length)
        {
            CurrentObject.sprite = spriteArray[i];
        }
        else
        {
            CurrentObject.sprite = spriteArray[0];
            dogIndex = 0;
        }

        switch(i)
        {
            case 0:
                Name = "Ethel";
                Breed = "Akita";
                Colour = "Black and white";
                Size = "big";
                Age = 2;
                Friendship = 0.00;
                break;

            case 1:
                Name = "Honey";
                Breed = "Golden Retriever";
                Colour = "Gold";
                Size = "big";
                Age = 2;
                Friendship = 0.00;
                break;

            case 2:
                Name = "Tangerine";
                Breed = "Corgi";
                Colour = "Orange";
                Size = "small";
                Age = 2;
                Friendship = 0.00;
                break;

            default:
                Name = "Ethel";
                Breed = "Akita";
                Colour = "Black and white";
                Size = "big";
                Age = 2;
                Friendship = 0.00;
                break;
        }
    }
}
