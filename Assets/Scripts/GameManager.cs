using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    enum Show { Cute, Cool, Smart, Fun};



    public GameObject selectedDog;
   

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null) instance = GameObject.FindObjectOfType<GameManager>();
            return instance;
        }
    }

    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        } else
        {
            DontDestroyOnLoad(gameObject);
        }

    }


    //enum practice (don't know how to use them yet)
    Show OppositeShow(Show myShow)
    {
        if (myShow == Show.Cute)
        {
            return Show.Cool;
        }
        else if (myShow == Show.Smart)
        {
            return Show.Fun;
        }
        else if (myShow == Show.Fun)
        {
            return Show.Smart;
        }
        else if (myShow == Show.Cool)
        {
            return Show.Cute;
        }
        else
            return myShow;

    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
