using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathsManager : MonoBehaviour
{
    [SerializeField] private CuteClothing SkirtandBow;

    // Start is called before the first frame update
    void Start()
    {
        Dog Puppy1 = new Dog("Honey", "Akita", "Black", "Large", 3, 0.5);

        Console.WriteLine(SkirtandBow.CoolPoints);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public int MainScore()
   // {
   //   ( x + y (( z/100)(x+y)))
        //SkirtandBow.PointsCalculation();
        //add other objects here
   // }
}
