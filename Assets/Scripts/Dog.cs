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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Naming()
    {
        //User input using on screen text box, Name = input
        //size/colour/age change depending on picked dog
    }
}
