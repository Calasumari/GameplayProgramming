using UnityEngine;
using TMPro;

//used a tutorial to start this part
// tutorial credit : https://projects.raspberrypi.org/en/projects/unity-textmeshpro-variable
public class ScoreText : MonoBehaviour
{
    public int score = 0; // The variable to display
    public TMP_Text scoreText; // The TextMeshPro object to display


    [SerializeField] MathsManager manager;

    public int placeholderScore;

    string scoreKey = "score";

    // Update is called once per frame
    void Update()
    {
        
        scoreText.SetText(score.ToString());
    }

    public void scoreGet()
    {
        
    }
    void Awake()
    {
        score = PlayerPrefs.GetInt(scoreKey);
    }

 

    
}