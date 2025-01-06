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

    enum collarName { Placeholder1, Placeholder2};

    // started as seperate scripts for every type of clothing but the maths manager means i can reduce it to three - one for each type


        // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


    public double PointsCalculation()
    {
        //might bit be needed, here as backup only
        double Cute = CutePoints * 1.2;
        double Cool = CoolPoints * 0.2;
        double Fun = FunPoints * 0.2;
        double Smart = SmartPoints * 0.2;

        return (Cute + Cool + Fun + Smart);
    }
}
