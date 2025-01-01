using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartClothes : MonoBehaviour
{
    public int CutePoints;
    public int CoolPoints;
    public int FunPoints;
    public int SmartPoints;
    public string Name;
    public string Type;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if signal received Score Caculation && position == (Wherever dog is) 
        // Final Points return

    }

    public double PointsCalculation()
    {
        double Cute = CutePoints * 0.2;
        double Cool = CoolPoints * 0.2;
        double Fun = FunPoints * 1.2;
        double Smart = SmartPoints * 0.2;

        return (Cute + Cool + Fun + Smart);
    }
}
