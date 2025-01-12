using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;

//used a tutorial to start this part
// tutorial credit : https://projects.raspberrypi.org/en/projects/unity-textmeshpro-variable
public class ScoreText : MonoBehaviour
{
    public int score = 0; // The variable to display
    public TMP_Text scoreText; // The TextMeshPro object to display

    public int shownumber;

    public int placeholderScore;

    string scoreKey = "score";
    string showKey = "show";

    public void scoreGet()
    {
        //scoreText.SetText(score.ToString());
        scoreText.text = FinalScore().ToString();
    }

    private void Start()
    {
        getShowType();
        Debug.Log("Show type is: " + shownumber);
        if (shownumber == 0)
        {
            ShowType = "Cute";
        }
        else if (shownumber == 1)
        {
            ShowType = "Cool";
        }
        else if(shownumber == 2)
        {
            ShowType = "Smart";
        }
        else
        {
            ShowType = "Fun";
        }
    }
    public void onButtonPressed()
    {
        Debug.Log(MainPoints());
        Debug.Log(CollarPoints());
        Debug.Log(AccessoryBonus());
        Debug.Log(FinalScore());
        //score = FinalScore();
        scoreGet();
    }
    void Awake()
    {
        score = PlayerPrefs.GetInt(scoreKey);
    }

    void getShowType()
    {
        shownumber = PlayerPrefs.GetInt(showKey);
    }

    [SerializeField] private Main Main;
    [SerializeField] private Collar Collar;
    [SerializeField] private Accessory Accessory;
    [SerializeField] private Button scoreButton;

    //taken from maths manager as a temporary fix

    public string ShowType = "Cute";

    public int MainPoints()
    {
        double cute;
        double cool;
        double fun;
        double Smart;

        int addPoints;
        if (ShowType == "Cute")
        {
            cute = Main.CutePoints * 1.2;
            cool = Main.CoolPoints * 0.2;
            fun = Main.FunPoints * 0.2;
            Smart = Main.SmartPoints * 0.2;
        }

        else if (ShowType == "Cool")
        {
            cute = Main.CutePoints * 0.2;
            cool = Main.CoolPoints * 1.2;
            fun = Main.FunPoints * 0.2;
            Smart = Main.SmartPoints * 0.2;
        }

        else if (ShowType == "Fun")
        {
            cute = Main.CutePoints * 0.2;
            cool = Main.CoolPoints * 0.2;
            fun = Main.FunPoints * 1.2;
            Smart = Main.SmartPoints * 0.2;
        }

        else if (ShowType == "Smart")
        {
            cute = Main.CutePoints * 0.2;
            cool = Main.CoolPoints * 0.2;
            fun = Main.FunPoints * 0.2;
            Smart = Main.SmartPoints * 1.2;
        }

        else
        {
            Debug.Log(message: "Show Type not found");
            return 0;
        }

        double addPoints1 = (cute + cool + fun + Smart);
        addPoints = (int)addPoints1;

        Debug.Log("Cute: " + cute);
        Debug.Log("Cool: " + cool);
        Debug.Log("fun: " + fun);
        Debug.Log("smart: " + Smart);
        Debug.Log("total: " + addPoints1);


        return addPoints;
    }

    public int CollarPoints()
    {
        int addPoints;
        if (ShowType == "Cute")
        {
            double cute = Main.CutePoints * 1.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            return addPoints;
        }

        else if (ShowType == "Cool")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 1.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            return addPoints;
        }

        else if (ShowType == "Fun")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 1.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            return addPoints;
        }

        else if (ShowType == "Smart")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 1.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;
            return addPoints;
        }

        else
        {
            Debug.Log(message: "Show Type not found");
            return 0;
        }
    }

    public double AccessoryBonus()
    {
        int addPoints;
        if (ShowType == "Cute")
        {
            double cute = Main.CutePoints * 1.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;

        }

        else if (ShowType == "Cool")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 1.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;

        }

        else if (ShowType == "Fun")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 1.2;
            double Smart = Main.SmartPoints * 0.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;

        }

        else if (ShowType == "Smart")
        {
            double cute = Main.CutePoints * 0.2;
            double cool = Main.CoolPoints * 0.2;
            double fun = Main.FunPoints * 0.2;
            double Smart = Main.SmartPoints * 1.2;

            double addPoints1 = (cute + cool + fun + Smart);
            addPoints = (int)addPoints1;

        }

        else
        {
            Debug.Log(message: "Show Type not found");
            return 0;
        }

        addPoints = addPoints / 100;

        return addPoints;
    }

    public int FinalScore()
    {
        double finalPoints = MainPoints() + CollarPoints() * AccessoryBonus();
        //Debug.Log("Le score: " + MainPoints());
        //Debug.Log("Le Collar: " + CollarPoints());
        //Debug.Log("Le Accessorr: " + AccessoryBonus());

        int score;
        score = Convert.ToInt32(finalPoints);

        Debug.Log("Le score: " + score);
        return score;
    }


}