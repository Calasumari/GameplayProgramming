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

    public Dog(string DogName, string DogBreed, string DogColour, string DogSize, int DogAge, double DogFriendship)
    {
        Name = DogName;
        Breed = DogBreed;
        Colour = DogColour;
        Size = DogSize;
        Age = DogAge;
        Friendship = DogFriendship;
    }

    // Start is called before the first frame update
    void Start()
    {
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
