using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowType : MonoBehaviour
{

    public int currentShow { get; set; }

    string showKey = "show";

    
    public void SetShow(int show)
    {
        PlayerPrefs.SetInt(showKey, show);
    }

    /*
    public void CuteShow()
    {
        SetShow(0);
    }

    public void CoolShow()
    {
        SetShow(1);
    }

    public void SmartShow()
    {
        SetShow(2);
    }

    public void FunShow()
    {
        SetShow(3);
    }
    */
}
