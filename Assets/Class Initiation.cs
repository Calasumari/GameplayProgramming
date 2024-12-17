using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puppy
{
    public string name, breed, colour;
    public int age, friendship, skill;

    public Puppy(string puppyName, string puppyBreed, string puppyColour, int puppyAge, int puppyFriendship, int PuppySkill)
    {
        name = puppyName;
        breed = puppyBreed;
        colour = puppyColour;
        age = puppyAge;
        friendship = puppyFriendship;
        skill = PuppySkill;
    }
}

public class Clothing
{
    public string name, speciality;
    public int cute, cool, fun, smart;

    public Clothing(string clothingName, string clothingSpeciality, int cutePoints, int coolPoints, int funPoints, int smartPoints)
    {
        name = clothingName;
        speciality = clothingSpeciality;
        cute = cutePoints;
        cool = coolPoints;
        fun = funPoints;
        smart = smartPoints;
    }
}

class Accesory
{
    private string type = "Accessory";
}

class Main
{
    private string type = "Main";
}

class Collar
{
    private string type = "Collar";
}

public class Show
{
    public string type;
    public int difficulty;

    public Show(string showType, int showDifficulty)
    {
        type = showType;
        difficulty = showDifficulty;
    }
}

public class ClassInitiation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
